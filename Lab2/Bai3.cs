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
    public partial class frmB3 : Form
    {
        public frmB3()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            // input file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            // Đọc file
            StreamReader str = new StreamReader(ofd.FileName);

            // Xử lý từng hàng phép tính
            for (int i = 0; !str.EndOfStream; ++i)
            {
                string content = str.ReadLine();

                // Lọc khoảng trắng
                char[] kitudacbiet = { ' ', '+', '-', '*', '/' };
                string[] source = { };
                float result = 0;
                // Xử lý phép tính
                if (content.Contains("+"))
                {
                    source = content.Split(
                    kitudacbiet, StringSplitOptions.RemoveEmptyEntries);
                    result = float.Parse(source[0]) + float.Parse(source[1]);
                }
                else if (content.Contains("-"))
                {
                    source = content.Split(
                    kitudacbiet, StringSplitOptions.RemoveEmptyEntries);
                    result = float.Parse(source[0]) - float.Parse(source[1]);
                }
                else if (content.Contains("*"))
                {
                    source = content.Split(
                    kitudacbiet, StringSplitOptions.RemoveEmptyEntries);
                    result = float.Parse(source[0]) * float.Parse(source[1]);
                }
                else if (content.Contains("/"))
                {
                    source = content.Split(
                    kitudacbiet, StringSplitOptions.RemoveEmptyEntries);
                    result = float.Parse(source[0]) / float.Parse(source[1]);
                }
                // In kết quả             
                rtbFile.Text += content;
                rtbFile.Text += "=";
                rtbFile.Text += result.ToString();
                rtbFile.Text += "\n";
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất kết quả ra file OutputB3.txt", "Output");
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\OutputB3.t";

            if (!File.Exists(path))
            {
                using (StreamWriter str = File.CreateText(path))
                {
                    str.Write(rtbFile.Text);
                }
            }
            else
                using (StreamWriter str = new StreamWriter(path))
                {
                    str.Write(rtbFile.Text);
                }
        }
    
    }
}
