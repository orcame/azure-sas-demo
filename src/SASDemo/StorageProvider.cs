using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Shared.Protocol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASDemo
{
    public class StorageProvider
    {
        private static readonly string connectionString = System.Configuration.ConfigurationManager.AppSettings["storageConnectionString"].ToString();
        private static readonly int blockSize = Math.Max(1,
            Math.Min(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["blockSizeKB"].ToString())
                , 4096)) * 1024;//max block size is 4M, and min block size is 1K

        private CloudStorageAccount account;
        private CloudBlobClient client;

        public StorageProvider()
        {
            account = CloudStorageAccount.Parse(connectionString);

            client = account.CreateCloudBlobClient();
        }

        public void SetCors()
        {
            var propers = client.GetServiceProperties();
            CorsRule cr = new CorsRule();
            cr.AllowedMethods = CorsHttpMethods.Put | CorsHttpMethods.Options | CorsHttpMethods.Post | CorsHttpMethods.Delete | CorsHttpMethods.Get;
            cr.AllowedOrigins.Add("*");
            cr.AllowedHeaders.Add("*");
            cr.MaxAgeInSeconds = 200;
            propers.Cors = new CorsProperties();
            propers.Cors.CorsRules.Add(cr);
            client.SetServiceProperties(propers);
        }

        public CloudBlobContainer GetContainer(string containerName)
        {
            if (containerName.StartsWith("https:"))
            {
                return new CloudBlobContainer(new Uri(containerName));
            }
            CloudBlobContainer container = client.GetContainerReference(containerName);

            container.CreateIfNotExists();
            return container;
        }

        public IEnumerable<BlobInfo> GetBlobList(string containerName)
        {
            CloudBlobContainer container = GetContainer(containerName);
            foreach (var item in container.ListBlobs().ToList())
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = item as CloudBlockBlob;
                    yield return new BlobInfo()
                    {
                        ContainerName = containerName,
                        BlobName = blob.Name,
                        Uri = blob.Uri.ToString()
                    };
                }
            }
        }

        public IEnumerable<CloudBlobContainer> GetContainers()
        {
            return client.ListContainers();
        }

        public void UploadBlob(string containerName, string blobName, string filePath)
        {
            CloudBlobContainer container = GetContainer(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);

            using (var fileStream = System.IO.File.OpenRead(filePath))
            {
                if (fileStream.Length <= blockSize)
                {
                    blob.UploadFromStream(fileStream);
                }
                else
                {
                    int idx = 0;
                    var blockIdList = new List<string>();
                    while (fileStream.Position < fileStream.Length)
                    {
                        var bufferSize = Math.Min(blockSize, fileStream.Length - fileStream.Position);
                        var buffer = new byte[bufferSize];
                        fileStream.Read(buffer, 0, buffer.Length);
                        using (var stream = new MemoryStream(buffer))
                        {
                            stream.Position = 0;
                            string blockId = Convert.ToBase64String(Encoding.UTF8.GetBytes(idx.ToString(CultureInfo.InvariantCulture).PadLeft(32, '0')));
                            blob.PutBlock(blockId, stream, null);
                            blockIdList.Add(blockId);
                            idx++;
                        }
                    }
                    blob.PutBlockList(blockIdList);
                }
            }
        }

        public void DownloadBlob(string containerName, string blobName, string filePath)
        {
            CloudBlobContainer container = GetContainer(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);
            using (var fileStream = System.IO.File.OpenWrite(filePath))
            {

                byte[] buffer = new byte[blockSize];
                int blobOffset = 0;
                while (true)
                {
                    int len = blob.DownloadRangeToByteArray(buffer, 0, blobOffset, blockSize);
                    blobOffset += len;
                    fileStream.Write(buffer, 0, len);
                    if (len < blockSize)
                    {
                        break;
                    }
                }
            }
        }

        public void DeleteBlob(string containerName, string blobName)
        {
            CloudBlobContainer container = GetContainer(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);
            blob.Delete();
        }

        public void SetContainerSap(string containerName, string policyName, DateTime? startTime, DateTime expiryTime, SharedAccessBlobPermissions permission)
        {
            CloudBlobContainer container = GetContainer(containerName);
            SharedAccessBlobPolicy sharedPolicy = new SharedAccessBlobPolicy()
            {
                SharedAccessStartTime = startTime,
                SharedAccessExpiryTime = expiryTime,
                Permissions = permission
            };
            BlobContainerPermissions permissions = new BlobContainerPermissions();
            permissions.SharedAccessPolicies.Clear();
            permissions.SharedAccessPolicies.Add(policyName, sharedPolicy);
            container.SetPermissions(permissions);
        }

        public void RemoveContainerSap(string containerName, string policyName)
        {
            CloudBlobContainer container = GetContainer(containerName);
            BlobContainerPermissions permissions = container.GetPermissions();
            permissions.SharedAccessPolicies.Remove(policyName);
            container.SetPermissions(permissions);
        }

        public string GenerateContainerSasUri(string containerName, DateTime? startTime, DateTime expiryTime, SharedAccessBlobPermissions permission)
        {
            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = startTime;
            sasConstraints.SharedAccessExpiryTime = expiryTime;
            sasConstraints.Permissions = permission;
            CloudBlobContainer container = GetContainer(containerName);
            var sas = container.GetSharedAccessSignature(sasConstraints);
            return container.Uri + sas;
        }

        public string GenerateContainerSasUri(string containerName, string policyName)
        {
            CloudBlobContainer container = GetContainer(containerName);
            string sasContainerToken = container.GetSharedAccessSignature(null, policyName);
            return container.Uri + sasContainerToken;
        }

        public string GenerateBlobSasUri(string containerName, string blobName, DateTime? startTime, DateTime expiryTime, SharedAccessBlobPermissions permission)
        {
            CloudBlobContainer container = GetContainer(containerName);
            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);
            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = startTime;
            sasConstraints.SharedAccessExpiryTime = expiryTime;
            sasConstraints.Permissions = permission;

            string sas = blob.GetSharedAccessSignature(sasConstraints);
            return blob.Uri + sas;
        }
    }
}
