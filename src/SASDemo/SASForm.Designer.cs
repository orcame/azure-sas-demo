namespace SASDemo
{
    partial class SASForm
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
            this.ckRead = new System.Windows.Forms.CheckBox();
            this.ckWrite = new System.Windows.Forms.CheckBox();
            this.ckDelete = new System.Windows.Forms.CheckBox();
            this.ckList = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckRead
            // 
            this.ckRead.AutoSize = true;
            this.ckRead.Checked = true;
            this.ckRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRead.Location = new System.Drawing.Point(6, 19);
            this.ckRead.Name = "ckRead";
            this.ckRead.Size = new System.Drawing.Size(52, 17);
            this.ckRead.TabIndex = 0;
            this.ckRead.Text = "Read";
            this.ckRead.UseVisualStyleBackColor = true;
            // 
            // ckWrite
            // 
            this.ckWrite.AutoSize = true;
            this.ckWrite.Checked = true;
            this.ckWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckWrite.Location = new System.Drawing.Point(6, 43);
            this.ckWrite.Name = "ckWrite";
            this.ckWrite.Size = new System.Drawing.Size(51, 17);
            this.ckWrite.TabIndex = 1;
            this.ckWrite.Text = "Write";
            this.ckWrite.UseVisualStyleBackColor = true;
            // 
            // ckDelete
            // 
            this.ckDelete.AutoSize = true;
            this.ckDelete.Checked = true;
            this.ckDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDelete.Location = new System.Drawing.Point(6, 67);
            this.ckDelete.Name = "ckDelete";
            this.ckDelete.Size = new System.Drawing.Size(57, 17);
            this.ckDelete.TabIndex = 2;
            this.ckDelete.Text = "Delete";
            this.ckDelete.UseVisualStyleBackColor = true;
            // 
            // ckList
            // 
            this.ckList.AutoSize = true;
            this.ckList.Checked = true;
            this.ckList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckList.Location = new System.Drawing.Point(6, 91);
            this.ckList.Name = "ckList";
            this.ckList.Size = new System.Drawing.Size(42, 17);
            this.ckList.TabIndex = 3;
            this.ckList.Text = "List";
            this.ckList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckRead);
            this.groupBox1.Controls.Add(this.ckList);
            this.groupBox1.Controls.Add(this.ckWrite);
            this.groupBox1.Controls.Add(this.ckDelete);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEndTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtStartTime);
            this.groupBox2.Location = new System.Drawing.Point(130, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit : S";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(75, 59);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 1;
            this.txtEndTime.Text = "72000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ExpirTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(75, 21);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 0;
            this.txtStartTime.Text = "-3600";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Set SAS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Policy Name";
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(81, 13);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(248, 20);
            this.txtPolicyName.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(252, 174);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Rmove SAS";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SASForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 205);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtPolicyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SASForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SASForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckRead;
        private System.Windows.Forms.CheckBox ckWrite;
        private System.Windows.Forms.CheckBox ckDelete;
        private System.Windows.Forms.CheckBox ckList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Button btnRemove;
    }
}