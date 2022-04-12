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
    public partial class frmVD2 : Form
    {
        public frmVD2()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);

            int[] myarray = new int[1000];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = i;
                bw.Write(myarray[i]);
            }
            bw.Close();
            fs.Close();
        }
    }
}
