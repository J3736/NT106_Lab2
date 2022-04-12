namespace Lab2
{
    partial class frmB4
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
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbP1 = new System.Windows.Forms.TextBox();
            this.tbP2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbSV = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(90, 34);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(72, 25);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(90, 81);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(90, 139);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(138, 25);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Location = new System.Drawing.Point(90, 196);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(126, 25);
            this.lbP1.TabIndex = 3;
            this.lbP1.Text = "Điểm môn 1";
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(90, 249);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(126, 25);
            this.lbP2.TabIndex = 4;
            this.lbP2.Text = "Điểm môn 2";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(343, 28);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(268, 31);
            this.tbMSSV.TabIndex = 5;
            this.tbMSSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(343, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 31);
            this.tbName.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(343, 139);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(268, 31);
            this.tbPhone.TabIndex = 7;
            // 
            // tbP1
            // 
            this.tbP1.Location = new System.Drawing.Point(343, 196);
            this.tbP1.Name = "tbP1";
            this.tbP1.Size = new System.Drawing.Size(268, 31);
            this.tbP1.TabIndex = 8;
            // 
            // tbP2
            // 
            this.tbP2.Location = new System.Drawing.Point(343, 249);
            this.tbP2.Name = "tbP2";
            this.tbP2.Size = new System.Drawing.Size(268, 31);
            this.tbP2.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm SV";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 55);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(480, 323);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(131, 55);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Đọc";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbSV);
            this.groupBox1.Location = new System.Drawing.Point(42, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 348);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // lstbSV
            // 
            this.lstbSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbSV.FormattingEnabled = true;
            this.lstbSV.ItemHeight = 25;
            this.lstbSV.Location = new System.Drawing.Point(3, 27);
            this.lstbSV.Name = "lstbSV";
            this.lstbSV.Size = new System.Drawing.Size(604, 318);
            this.lstbSV.TabIndex = 0;
            // 
            // frmB4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 804);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbP2);
            this.Controls.Add(this.tbP1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMSSV);
            this.Controls.Add(this.lbP2);
            this.Controls.Add(this.lbP1);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMSSV);
            this.Name = "frmB4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbP1;
        private System.Windows.Forms.TextBox tbP2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbSV;
    }
}