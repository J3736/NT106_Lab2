namespace Lab2
{
    partial class frmVD1
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
            this.btnRL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRL
            // 
            this.btnRL.Location = new System.Drawing.Point(207, 45);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(210, 60);
            this.btnRL.TabIndex = 0;
            this.btnRL.Text = "READ LINE";
            this.btnRL.UseVisualStyleBackColor = true;
            this.btnRL.Click += new System.EventHandler(this.btnRL_Click);
            // 
            // frmVD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 152);
            this.Controls.Add(this.btnRL);
            this.Name = "frmVD1";
            this.Text = "VD1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRL;
    }
}