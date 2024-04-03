using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UocSo
{
    public partial class Form1 : Form
    {
        bool primeCheck(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_NhapSo.Text != "")
            {
                if (!comboBox_SoDaNhap.Items.Contains(textBox_NhapSo.Text))
                {
                    comboBox_SoDaNhap.Items.Add(textBox_NhapSo.Text);
                }
            }

            textBox_NhapSo.Clear();
            textBox_NhapSo.Focus();
        }

        private void comboBox_SoDaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_UocSo.Items.Clear();

            int a = int.Parse(comboBox_SoDaNhap.SelectedItem.ToString());

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    listBox_UocSo.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;

            foreach (int v in listBox_UocSo.Items)
            {
                result += v;
            }

            MessageBox.Show("Tổng các ước số là: " +  result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = 0;

            foreach (int v in listBox_UocSo.Items)
            {
                if (v % 2 == 0)
                {
                    result += 1;
                }
            }

            MessageBox.Show("Số lượng các ước số chẵn là: " + result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result = 0;

            foreach (int v in listBox_UocSo.Items)
            {
                if (primeCheck(v))
                {
                    result += 1;
                }
            }

            MessageBox.Show("Số lượng các ước số nguyên tố là: " + result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
