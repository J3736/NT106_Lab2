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
    public partial class frmVD1 : Form
    {
        public frmVD1()
        {
            InitializeComponent();
        }

        private void btnRL_Click(object sender, EventArgs e)
        {
            // Chọn đường dẫn của File.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            int line = 0;
            while (sr.ReadLine() != null)
            {
                line++;
            }
            fs.Close();
            MessageBox.Show("There are " + line + " in " + ofd.FileName, "Lines");
        }
    }
}
