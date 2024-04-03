using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_AX_B_0
{
    public partial class Form1 : Form
    {
        bool check()
        {
            int a, b;
            if (int.TryParse(textBox_NhapA.Text, out a) && int.TryParse(textBox_NhapB.Text, out b))
            {
                errorProvider1.Clear();

                button_Giai.Enabled = true;
                button_Xoa.Enabled = true;

                return true;
            } else
            {
                button_Giai.Enabled = false;
                button_Xoa.Enabled = false;
                textBox_Nghiem.Clear();

                errorProvider1.SetError(textBox_NhapA, "Vui lòng nhập số hợp lệ!");

                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }



        private void button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_Giai_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox_NhapA.Text, out a) && int.TryParse(textBox_NhapB.Text, out b))
            {
                if (!check())
                {
                    return;
                } else
                {
                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            textBox_Nghiem.Text = "Phương trình có vô số nghiệm";
                        } else
                        {
                            textBox_Nghiem.Text = "Phương trình vô nghiệm";
                        }
                    }
                    else
                    {
                        double result = (double)(-b) / a;
                        textBox_Nghiem.Text = result.ToString();
                    }
                }
            }
        }

        private void textBox_NhapA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NhapA_Leave(object sender, EventArgs e)
        {
            check();
        }

        private void textBox_NhapB_Leave(object sender, EventArgs e)
        {
            check();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox_NhapA.Clear();
                textBox_NhapB.Clear();
                textBox_Nghiem.Clear();

                button_Giai.Enabled = false;
                button_Xoa.Enabled = false;
            }
        }
    }
}
