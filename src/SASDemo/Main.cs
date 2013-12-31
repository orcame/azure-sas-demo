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
    public partial class Main : Form
    {
        private StorageProvider provider = new StorageProvider();
        BindingSource containerSource = null;
        public Main()
        {
            InitializeComponent();
            containerSource = new BindingSource();

            containerSource.DataSource = provider.GetContainers();
            //containerSource.datam
            cmbContainers.DataSource = containerSource;
            containerSource.CurrentChanged += containerSource_CurrentChanged;
            cmbContainers.DisplayMember = "Name";
            gridBlobs.AutoGenerateColumns = true;
            LoadBlobList();

        }

        private string CurrentContainerName
        {
            get
            {
                var container = containerSource.Current as CloudBlobContainer;
                if (container == null)
                {
                    throw new Exception("Please select a container first.");
                }
                return container.Name;
            }
        }

        private string CurrentBlobName
        {
            get
            {
                if (gridBlobs.CurrentRow == null)
                {
                    return "";
                }
                var blob = gridBlobs.CurrentRow.DataBoundItem as BlobInfo;
                if (blob != null)
                {
                    return blob.BlobName;
                }
                return "";
            }
        }

        private void LoadBlobList()
        {
            gridBlobs.AutoGenerateColumns = true;
            gridBlobs.DataSource = null;
            string name = CurrentContainerName;
            gridBlobs.DataSource = provider.GetBlobList(name).ToList();
        }

        private void containerSource_CurrentChanged(object sender, EventArgs e)
        {
            LoadBlobList();
        }

        private void WriteOutput(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                txtOutput.AppendText(message);
                txtOutput.AppendText(Environment.NewLine);
            }
        }

        private void menuUploadBlob_Click(object sender, EventArgs e)
        {
            FileOperationForm fof = new FileOperationForm(FileOperationModel.Upload, CurrentContainerName, "");
            if (fof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadBlobList();
                WriteOutput("Upload blob success.");
            }
        }

        private void menuDownloadBlob_Click(object sender, EventArgs e)
        {
            FileOperationForm fof = new FileOperationForm(FileOperationModel.Download, CurrentContainerName, CurrentBlobName);
            if (fof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WriteOutput("Download blob success.");
            }
        }

        private void menuDeleteBlob_Click(object sender, EventArgs e)
        {
            FileOperationForm fof = new FileOperationForm(FileOperationModel.Delete, CurrentContainerName, CurrentBlobName);
            if (fof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadBlobList();
                WriteOutput("Delete blob success.");
            }
        }

        private void menuRemoveContainerSAS_Click(object sender, EventArgs e)
        {
            SASForm sas = new SASForm(CurrentContainerName, "");
            if (sas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WriteOutput("Remove Policy Success.");
            }
        }

        private void menuSetContailerSAS_Click(object sender, EventArgs e)
        {
            SASForm sas = new SASForm(CurrentContainerName, "");
            if (sas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WriteOutput(sas.Signature);
            }
        }

        private void menuSetBlobSAS_Click(object sender, EventArgs e)
        {
            SASForm sas = new SASForm(CurrentContainerName, CurrentBlobName);
            if (sas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WriteOutput(sas.Signature);
            }
        }

        private void menuSetSAP_Click(object sender, EventArgs e)
        {
            SASForm sas = new SASForm(CurrentContainerName, CurrentBlobName, SharedAccessOperationType.SAP);
            if (sas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WriteOutput(sas.Signature);
            }
        }

        private void menuSetCors_Click(object sender, EventArgs e)
        {
            provider.SetCors();
        }
    }
}
