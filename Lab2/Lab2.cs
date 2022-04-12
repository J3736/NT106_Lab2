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
    public partial class frmL2 : Form
    {
        public frmL2()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmB4 frm = new frmB4();
            if (Application.OpenForms.OfType<frmB4>().Any())
                MessageBox.Show("Form is opened");
            else
                frm.Show();
        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            frmVD1 frm = new frmVD1();
            if (Application.OpenForms.OfType<frmVD1>().Any())
                MessageBox.Show("Form is opened");
            else
                frm.Show();
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            frmVD2 frm = new frmVD2();
            if (Application.OpenForms.OfType<frmVD2>().Any())
                MessageBox.Show("Form is opened");
            else
                frm.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmB1 frm = new frmB1();
            if (Application.OpenForms.OfType<frmB1>().Any())
                MessageBox.Show("Form is opened.");
            else
                frm.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmB2 frm = new frmB2();
            if (Application.OpenForms.OfType<frmB2>().Any())
                MessageBox.Show("Form is opened.");
            else
                frm.Show();
        }
    }
}
