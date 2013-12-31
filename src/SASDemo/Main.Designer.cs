namespace SASDemo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbContainers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridBlobs = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuSetSAS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetContailerSAS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetBlobSAS = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveContainerSAS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetSAP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUploadBlob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDownloadBlob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteBlob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetCors = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlobs)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbContainers);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Containers";
            // 
            // cmbContainers
            // 
            this.cmbContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainers.FormattingEnabled = true;
            this.cmbContainers.Location = new System.Drawing.Point(3, 16);
            this.cmbContainers.Name = "cmbContainers";
            this.cmbContainers.Size = new System.Drawing.Size(916, 21);
            this.cmbContainers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridBlobs);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blobs";
            // 
            // gridBlobs
            // 
            this.gridBlobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridBlobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBlobs.Location = new System.Drawing.Point(3, 16);
            this.gridBlobs.Name = "gridBlobs";
            this.gridBlobs.Size = new System.Drawing.Size(915, 346);
            this.gridBlobs.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(921, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(915, 127);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 87);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(921, 515);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 3;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetSAS,
            this.removeSASToolStripMenuItem,
            this.menuSetSAP,
            this.menuUploadBlob,
            this.menuDownloadBlob,
            this.menuDeleteBlob,
            this.menuSetCors});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(946, 24);
            this.menuMain.TabIndex = 4;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuSetSAS
            // 
            this.menuSetSAS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetContailerSAS,
            this.menuSetBlobSAS});
            this.menuSetSAS.Name = "menuSetSAS";
            this.menuSetSAS.Size = new System.Drawing.Size(58, 20);
            this.menuSetSAS.Text = "Set SAS";
            // 
            // menuSetContailerSAS
            // 
            this.menuSetContailerSAS.Name = "menuSetContailerSAS";
            this.menuSetContailerSAS.Size = new System.Drawing.Size(126, 22);
            this.menuSetContailerSAS.Text = "Container";
            this.menuSetContailerSAS.Click += new System.EventHandler(this.menuSetContailerSAS_Click);
            // 
            // menuSetBlobSAS
            // 
            this.menuSetBlobSAS.Name = "menuSetBlobSAS";
            this.menuSetBlobSAS.Size = new System.Drawing.Size(126, 22);
            this.menuSetBlobSAS.Text = "Blob";
            this.menuSetBlobSAS.Click += new System.EventHandler(this.menuSetBlobSAS_Click);
            // 
            // removeSASToolStripMenuItem
            // 
            this.removeSASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRemoveContainerSAS});
            this.removeSASToolStripMenuItem.Name = "removeSASToolStripMenuItem";
            this.removeSASToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.removeSASToolStripMenuItem.Text = "Remove SAS";
            // 
            // menuRemoveContainerSAS
            // 
            this.menuRemoveContainerSAS.Name = "menuRemoveContainerSAS";
            this.menuRemoveContainerSAS.Size = new System.Drawing.Size(126, 22);
            this.menuRemoveContainerSAS.Text = "Container";
            this.menuRemoveContainerSAS.Click += new System.EventHandler(this.menuRemoveContainerSAS_Click);
            // 
            // menuSetSAP
            // 
            this.menuSetSAP.Name = "menuSetSAP";
            this.menuSetSAP.Size = new System.Drawing.Size(59, 20);
            this.menuSetSAP.Text = "Set SAP";
            this.menuSetSAP.Click += new System.EventHandler(this.menuSetSAP_Click);
            // 
            // menuUploadBlob
            // 
            this.menuUploadBlob.Name = "menuUploadBlob";
            this.menuUploadBlob.Size = new System.Drawing.Size(57, 20);
            this.menuUploadBlob.Text = "Upload";
            this.menuUploadBlob.Click += new System.EventHandler(this.menuUploadBlob_Click);
            // 
            // menuDownloadBlob
            // 
            this.menuDownloadBlob.Name = "menuDownloadBlob";
            this.menuDownloadBlob.Size = new System.Drawing.Size(73, 20);
            this.menuDownloadBlob.Text = "Download";
            this.menuDownloadBlob.Click += new System.EventHandler(this.menuDownloadBlob_Click);
            // 
            // menuDeleteBlob
            // 
            this.menuDeleteBlob.Name = "menuDeleteBlob";
            this.menuDeleteBlob.Size = new System.Drawing.Size(52, 20);
            this.menuDeleteBlob.Text = "Delete";
            this.menuDeleteBlob.Click += new System.EventHandler(this.menuDeleteBlob_Click);
            // 
            // menuSetCors
            // 
            this.menuSetCors.Name = "menuSetCors";
            this.menuSetCors.Size = new System.Drawing.Size(62, 20);
            this.menuSetCors.Text = "Set Cors";
            this.menuSetCors.Click += new System.EventHandler(this.menuSetCors_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 614);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Main";
            this.Text = "Shared Access Signatures Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlobs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridBlobs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbContainers;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuSetSAS;
        private System.Windows.Forms.ToolStripMenuItem menuSetContailerSAS;
        private System.Windows.Forms.ToolStripMenuItem menuSetBlobSAS;
        private System.Windows.Forms.ToolStripMenuItem removeSASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveContainerSAS;
        private System.Windows.Forms.ToolStripMenuItem menuUploadBlob;
        private System.Windows.Forms.ToolStripMenuItem menuDownloadBlob;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteBlob;
        private System.Windows.Forms.ToolStripMenuItem menuSetSAP;
        private System.Windows.Forms.ToolStripMenuItem menuSetCors;
    }
}

