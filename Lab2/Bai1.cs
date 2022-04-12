using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class frmB1 : Form
    {
        string content;
        public frmB1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            
            // Ghi xuong file
            StreamWriter sw = new StreamWriter(sfd.FileName);
            content = rtbMessage.Text;
            content = content.ToUpper();
            sw.Write(content);
            sw.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader str = new StreamReader(fs);
            content = str.ReadToEnd();
            rtbMessage.Text = content;
            fs.Close();
            str.Close();
        }
    }
}
