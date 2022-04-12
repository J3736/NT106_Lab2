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
    public partial class frmB2 : Form
    {
        public frmB2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            // In ra man hinh
            StreamReader str = new StreamReader(ofd.FileName);
            string content = str.ReadToEnd();
            rtbReadFile.Text = content;

            // In ra thong tin cua file
            tbName.Text = ofd.SafeFileName.ToString();
            tbUrl.Text = ofd.FileName.ToString();

            int charcount = content.Length;
            tbSoKyTu.Text = charcount.ToString();

            content = content.Replace("\r\n", "\r");
            int lineCount = rtbReadFile.Lines.Count();
            content = content.Replace('\r',' ');    
            tbLine.Text = lineCount.ToString();

            string[] source = content.Split(
                new char[] { '.', '?', '!', ' ',';',':',',' },
                StringSplitOptions.RemoveEmptyEntries) ;
            int wordCount = source.Count();
            tbSoTu.Text = wordCount.ToString();
        }

        private void frmB2_Load(object sender, EventArgs e)
        {

        }
    }
}
