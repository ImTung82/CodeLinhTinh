using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhDangChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton_Red_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.ForeColor = Color.Red;
        }

        private void radioButton_Green_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.ForeColor = Color.Green;
        }

        private void radioButton_Blue_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.ForeColor = Color.Blue;
        }

        private void radioButton_Black_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.ForeColor = Color.Black;
        }

        private void textBox1_NhapTen_TextChanged(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox1_NhapTen.Text;
        }

        private void checkBox_Bold_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.Font = new Font(textBox_Result.Font.Name, textBox_Result.Font.Size, textBox_Result.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox_Italic_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.Font = new Font(textBox_Result.Font.Name, textBox_Result.Font.Size, textBox_Result.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox_Underline_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.Font = new Font(textBox_Result.Font.Name, textBox_Result.Font.Size, textBox_Result.Font.Style ^ FontStyle.Underline);
        }
    }
}
