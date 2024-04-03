using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void radioButton_Cong_CheckedChanged(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox_So1.Text, out a) && double.TryParse(textBox_So2.Text, out b))
            {
                double result = a + b;
                textBox_KetQua.Text = result.ToString();
            } 
            else
            {
                textBox_So1.Clear();
                textBox_So2.Clear();
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void radioButton_Tru_CheckedChanged(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox_So1.Text, out a) && double.TryParse(textBox_So2.Text, out b))
            {
                double result = a - b;
                textBox_KetQua.Text = result.ToString();
            }
            else
            {
                textBox_So1.Clear();
                textBox_So2.Clear();
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void radioButton_Nhan_CheckedChanged(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox_So1.Text, out a) && double.TryParse(textBox_So2.Text, out b))
            {
                double result = a * b;
                textBox_KetQua.Text = result.ToString();
            }
            else
            {
                textBox_So1.Clear();
                textBox_So2.Clear();
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void radioButton_Chia_CheckedChanged(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox_So1.Text, out a) && double.TryParse(textBox_So2.Text, out b))
            {
                double result = a / b;
                textBox_KetQua.Text = result.ToString();
            }
            else
            {
                textBox_So1.Clear();
                textBox_So2.Clear();
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void textBox_So1_TextChanged(object sender, EventArgs e)
        {
            radioButton_Cong.Checked = false;
            radioButton_Tru.Checked = false;
            radioButton_Nhan.Checked = false;
            radioButton_Chia.Checked = false;

            textBox_KetQua.Clear();
        }
    }
}
