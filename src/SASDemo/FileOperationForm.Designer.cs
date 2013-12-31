namespace SASDemo
{
    partial class FileOperationForm
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
            this.radioConnectionString = new System.Windows.Forms.RadioButton();
            this.radioSAS = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSAS = new System.Windows.Forms.RichTextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioConnectionString
            // 
            this.radioConnectionString.AutoSize = true;
            this.radioConnectionString.Location = new System.Drawing.Point(3, 3);
            this.radioConnectionString.Name = "radioConnectionString";
            this.radioConnectionString.Size = new System.Drawing.Size(195, 17);
            this.radioConnectionString.TabIndex = 0;
            this.radioConnectionString.Text = "Use Connection String in app.config";
            this.radioConnectionString.UseVisualStyleBackColor = true;
            this.radioConnectionString.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioSAS
            // 
            this.radioSAS.AutoSize = true;
            this.radioSAS.Checked = true;
            this.radioSAS.Location = new System.Drawing.Point(204, 3);
            this.radioSAS.Name = "radioSAS";
            this.radioSAS.Size = new System.Drawing.Size(172, 17);
            this.radioSAS.TabIndex = 1;
            this.radioSAS.TabStop = true;
            this.radioSAS.Text = "Use Shared Access Signatures";
            this.radioSAS.UseVisualStyleBackColor = true;
            this.radioSAS.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioConnectionString);
            this.panel1.Controls.Add(this.radioSAS);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 24);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSAS);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shared Access Signatures";
            // 
            // txtSAS
            // 
            this.txtSAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSAS.Location = new System.Drawing.Point(3, 16);
            this.txtSAS.Name = "txtSAS";
            this.txtSAS.Size = new System.Drawing.Size(592, 134);
            this.txtSAS.TabIndex = 0;
            this.txtSAS.Text = "";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(531, 319);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "button1";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowser);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Location = new System.Drawing.Point(13, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Path";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(511, 17);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(2, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(502, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBlobName);
            this.groupBox3.Location = new System.Drawing.Point(13, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 45);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blob Name";
            // 
            // txtBlobName
            // 
            this.txtBlobName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlobName.Location = new System.Drawing.Point(3, 16);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(591, 20);
            this.txtBlobName.TabIndex = 0;
            // 
            // FileOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FileOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileOperationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioConnectionString;
        private System.Windows.Forms.RadioButton radioSAS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtSAS;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBlobName;
    }
}