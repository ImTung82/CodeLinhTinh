using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiFont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", richTextBox1.Font.Size);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", richTextBox1.Font.Size);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Tahoma", richTextBox1.Font.Size);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Courier New", richTextBox1.Font.Size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
