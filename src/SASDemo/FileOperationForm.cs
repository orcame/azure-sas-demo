using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASDemo
{
    public partial class FileOperationForm : Form
    {
        private FileOperationModel model;
        private string containerName;

        public FileOperationForm(FileOperationModel model, string containerName, string blobName)
        {
            InitializeComponent();
            this.model = model;
            this.btnDone.Text = model.ToString();
            btnBrowser.Enabled = this.model != FileOperationModel.Delete;
            this.txtBlobName.Text = blobName;
            this.containerName = containerName;
            this.Text = string.Format("{0} {1}", this.model, blobName);
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FileDialog fd = null;
            switch (this.model)
            {
                case FileOperationModel.Upload:
                    fd = new OpenFileDialog();
                    break;
                case FileOperationModel.Download:
                    fd = new SaveFileDialog();
                    break;
                case FileOperationModel.Delete:
                default:
                    break;
            }
            if (fd != null && fd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fd.FileName;
                if (string.IsNullOrEmpty(txtBlobName.Text.Trim()))
                {
                    txtBlobName.Text = new FileInfo(fd.FileName).Name;
                }
            }
        }

        private string FilePath
        {
            get
            {
                if (txtFilePath.Text.Length > 0)
                {
                    return txtFilePath.Text;
                }
                throw new Exception("Please select a file first.");
            }
        }

        private string BlobName
        {
            get
            {
                if (!string.IsNullOrEmpty(txtBlobName.Text.Trim()))
                {
                    return txtBlobName.Text.Trim();
                }
                throw new Exception("Please input a blob name first.");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            StorageProvider provider = null;
            if (radioSAS.Checked)
            {
                containerName = txtSAS.Text;
            }
            provider = new StorageProvider();
            switch (this.model)
            {
                case FileOperationModel.Upload:
                    provider.UploadBlob(containerName, BlobName, FilePath);
                    break;
                case FileOperationModel.Download:
                    provider.DownloadBlob(containerName, BlobName, FilePath);
                    break;
                case FileOperationModel.Delete:
                    provider.DeleteBlob(containerName, BlobName);
                    break;
                default:
                    break;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            txtSAS.Enabled = radioSAS.Checked;
        }
    }
}
