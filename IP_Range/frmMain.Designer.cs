namespace IP_Range
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.btnFileAdd1 = new System.Windows.Forms.Button();
            this.txtFileInput1 = new System.Windows.Forms.TextBox();
            this.txtFileInput2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileAdd2 = new System.Windows.Forms.Button();
            this.chkSecondFile = new System.Windows.Forms.CheckBox();
            this.btnReadChck = new System.Windows.Forms.Button();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.lblOldFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxRegion
            // 
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "ap-northeast-1",
            "ap-southeast-1",
            "ap-southeast-2",
            "cn-north-1",
            "eu-central-1",
            "eu-west-1",
            "sa-east-1",
            "us-east-1",
            "us-gov-west-1",
            "us-west-1",
            "us-west-2",
            "GLOBAL"});
            this.cbxRegion.Location = new System.Drawing.Point(12, 103);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(119, 21);
            this.cbxRegion.TabIndex = 0;
            // 
            // cbxService
            // 
            this.cbxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Items.AddRange(new object[] {
            "AMAZON",
            "EC2",
            "CLOUDFRONT",
            "ROUTE53",
            "ROUTE53_HEALTHCHECKS"});
            this.cbxService.Location = new System.Drawing.Point(137, 103);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(145, 21);
            this.cbxService.TabIndex = 1;
            // 
            // btnFileAdd1
            // 
            this.btnFileAdd1.Location = new System.Drawing.Point(255, 20);
            this.btnFileAdd1.Name = "btnFileAdd1";
            this.btnFileAdd1.Size = new System.Drawing.Size(27, 23);
            this.btnFileAdd1.TabIndex = 3;
            this.btnFileAdd1.Text = "...";
            this.btnFileAdd1.UseVisualStyleBackColor = true;
            this.btnFileAdd1.Click += new System.EventHandler(this.btnFileAdd1_Click);
            // 
            // txtFileInput1
            // 
            this.txtFileInput1.Location = new System.Drawing.Point(12, 22);
            this.txtFileInput1.Name = "txtFileInput1";
            this.txtFileInput1.Size = new System.Drawing.Size(216, 20);
            this.txtFileInput1.TabIndex = 4;
            // 
            // txtFileInput2
            // 
            this.txtFileInput2.Location = new System.Drawing.Point(12, 61);
            this.txtFileInput2.Name = "txtFileInput2";
            this.txtFileInput2.Size = new System.Drawing.Size(216, 20);
            this.txtFileInput2.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileAdd2
            // 
            this.btnFileAdd2.Location = new System.Drawing.Point(255, 59);
            this.btnFileAdd2.Name = "btnFileAdd2";
            this.btnFileAdd2.Size = new System.Drawing.Size(27, 23);
            this.btnFileAdd2.TabIndex = 6;
            this.btnFileAdd2.Text = "...";
            this.btnFileAdd2.UseVisualStyleBackColor = true;
            this.btnFileAdd2.Click += new System.EventHandler(this.btnFileAdd2_Click);
            // 
            // chkSecondFile
            // 
            this.chkSecondFile.AutoSize = true;
            this.chkSecondFile.Checked = true;
            this.chkSecondFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecondFile.Location = new System.Drawing.Point(234, 64);
            this.chkSecondFile.Name = "chkSecondFile";
            this.chkSecondFile.Size = new System.Drawing.Size(15, 14);
            this.chkSecondFile.TabIndex = 7;
            this.chkSecondFile.UseVisualStyleBackColor = true;
            this.chkSecondFile.Click += new System.EventHandler(this.chkSecondFile_Click);
            // 
            // btnReadChck
            // 
            this.btnReadChck.Location = new System.Drawing.Point(12, 130);
            this.btnReadChck.Name = "btnReadChck";
            this.btnReadChck.Size = new System.Drawing.Size(103, 23);
            this.btnReadChck.TabIndex = 8;
            this.btnReadChck.Text = "Read and Check";
            this.btnReadChck.UseVisualStyleBackColor = true;
            this.btnReadChck.Click += new System.EventHandler(this.btnReadChck_Click);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(9, 84);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 9;
            this.lblRegion.Text = "Region";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(134, 84);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 10;
            this.lblService.Text = "Service";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 159);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIP.Size = new System.Drawing.Size(270, 101);
            this.txtIP.TabIndex = 12;
            // 
            // lblNewFile
            // 
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Location = new System.Drawing.Point(9, 6);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(48, 13);
            this.lblNewFile.TabIndex = 13;
            this.lblNewFile.Text = "New File";
            // 
            // lblOldFile
            // 
            this.lblOldFile.AutoSize = true;
            this.lblOldFile.Location = new System.Drawing.Point(9, 45);
            this.lblOldFile.Name = "lblOldFile";
            this.lblOldFile.Size = new System.Drawing.Size(42, 13);
            this.lblOldFile.TabIndex = 14;
            this.lblOldFile.Text = "Old File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.lblOldFile);
            this.Controls.Add(this.lblNewFile);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.btnReadChck);
            this.Controls.Add(this.chkSecondFile);
            this.Controls.Add(this.btnFileAdd2);
            this.Controls.Add(this.txtFileInput2);
            this.Controls.Add(this.txtFileInput1);
            this.Controls.Add(this.btnFileAdd1);
            this.Controls.Add(this.cbxService);
            this.Controls.Add(this.cbxRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS IP Range Comparer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.Button btnFileAdd1;
        private System.Windows.Forms.TextBox txtFileInput1;
        private System.Windows.Forms.TextBox txtFileInput2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileAdd2;
        private System.Windows.Forms.CheckBox chkSecondFile;
        private System.Windows.Forms.Button btnReadChck;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.Label lblOldFile;
    }
}

