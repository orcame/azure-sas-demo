using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASDemo
{
    public partial class SASForm : Form
    {
        private string containerName;

        private string blobName;

        private SharedAccessOperationType opType;

        public string Signature
        {
            get;
            private set;
        }

        public SASForm(string containerName, string blobName, SharedAccessOperationType opType = SharedAccessOperationType.SAS)
        {
            InitializeComponent();
            this.containerName = containerName;
            this.blobName = blobName;
            this.opType = opType;
        }

        private DateTime Now
        {
            get { return DateTime.Now; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SharedAccessBlobPermissions permission = SharedAccessBlobPermissions.None;
            if (ckRead.Checked)
            {
                permission = permission | SharedAccessBlobPermissions.Read;
            }
            if (ckWrite.Checked)
            {
                permission = permission | SharedAccessBlobPermissions.Write;
            }
            if (ckDelete.Checked)
            {
                permission = permission | SharedAccessBlobPermissions.Delete;
            }
            if (ckList.Checked)
            {
                permission = permission | SharedAccessBlobPermissions.List;
            }
            DateTime? startTime = null;
            if (txtStartTime.Text.Length > 0)
            {
                startTime = Now.AddSeconds(Convert.ToDouble(txtStartTime.Text));
            }
            DateTime endTime = startTime != null ? startTime.Value : Now;
            if (txtEndTime.Text.Length > 0)
            {
                endTime = endTime.AddSeconds(Convert.ToDouble(txtEndTime.Text));
            }
            StorageProvider provider = new StorageProvider();
            if (opType == SharedAccessOperationType.SAS)
            {
                if (!string.IsNullOrEmpty(blobName))
                {
                    Signature = provider.GenerateBlobSasUri(containerName, blobName, startTime, endTime, permission);
                }
                else
                {
                    Signature = provider.GenerateContainerSasUri(containerName,startTime, endTime, permission);
                }
            }
            else
            {
                provider.SetContainerSap(containerName, txtPolicyName.Text, startTime, endTime, permission);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            StorageProvider provider = new StorageProvider();
            provider.RemoveContainerSap(containerName, txtPolicyName.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
