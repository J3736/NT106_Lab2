namespace Lab2
{
    partial class frmB2
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbNameFile = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoKyTu = new System.Windows.Forms.TextBox();
            this.rtbReadFile = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "ĐỌC FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 228);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(254, 31);
            this.tbName.TabIndex = 1;
            // 
            // lbNameFile
            // 
            this.lbNameFile.AutoSize = true;
            this.lbNameFile.Location = new System.Drawing.Point(36, 231);
            this.lbNameFile.Name = "lbNameFile";
            this.lbNameFile.Size = new System.Drawing.Size(83, 25);
            this.lbNameFile.TabIndex = 2;
            this.lbNameFile.Text = "Tên file";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(36, 302);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(39, 25);
            this.lbLink.TabIndex = 4;
            this.lbLink.Text = "Url";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(174, 302);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(254, 31);
            this.tbUrl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số từ";
            // 
            // tbSoTu
            // 
            this.tbSoTu.Location = new System.Drawing.Point(174, 425);
            this.tbSoTu.Name = "tbSoTu";
            this.tbSoTu.ReadOnly = true;
            this.tbSoTu.Size = new System.Drawing.Size(254, 31);
            this.tbSoTu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số ký tự";
            // 
            // tbSoKyTu
            // 
            this.tbSoKyTu.Location = new System.Drawing.Point(174, 484);
            this.tbSoKyTu.Name = "tbSoKyTu";
            this.tbSoKyTu.ReadOnly = true;
            this.tbSoKyTu.Size = new System.Drawing.Size(254, 31);
            this.tbSoKyTu.TabIndex = 7;
            // 
            // rtbReadFile
            // 
            this.rtbReadFile.Location = new System.Drawing.Point(470, 61);
            this.rtbReadFile.Name = "rtbReadFile";
            this.rtbReadFile.Size = new System.Drawing.Size(508, 469);
            this.rtbReadFile.TabIndex = 9;
            this.rtbReadFile.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số dòng";
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(174, 362);
            this.tbLine.Name = "tbLine";
            this.tbLine.ReadOnly = true;
            this.tbLine.Size = new System.Drawing.Size(254, 31);
            this.tbLine.TabIndex = 10;
            // 
            // frmB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLine);
            this.Controls.Add(this.rtbReadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoKyTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoTu);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lbNameFile);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button1);
            this.Name = "frmB2";
            this.Text = "BÀI 2";
            this.Load += new System.EventHandler(this.frmB2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbNameFile;
        private System.Windows.Forms.Label lbLink;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoKyTu;
        private System.Windows.Forms.RichTextBox rtbReadFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLine;
    }
}