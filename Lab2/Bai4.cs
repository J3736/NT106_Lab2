using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmB4 : Form
    {
        public frmB4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List <SinhVien> dssv = new List<SinhVien> ();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien ();
            sv.MSSV = int.Parse(tbMSSV.Text);
            sv.Name = tbName.Text;
            sv.PhoneNumber = tbPhone.Text;
            sv.Diem1 = float.Parse(tbP1.Text);
            sv.Diem2 = float.Parse(tbP2.Text);
            dssv.Add (sv);
            ShowDSSV();
        }

        private void ShowDSSV()
        {
            lstbSV.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                lstbSV.Items.Add(sv);
            }
        }

        private void rtbSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Bai4.txt";
            bool check = SaveFileB4.Save(dssv, path);
            if (check)
            {
                MessageBox.Show("Save Successful!");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Bai4.txt";
            dssv = SaveFileB4.Read(path);
            ShowDSSV ();
        }
    }
}
