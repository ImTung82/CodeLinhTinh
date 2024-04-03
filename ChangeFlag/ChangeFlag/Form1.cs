using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeFlag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_Vietnam_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Flag.Image = new Bitmap("C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\ChangeFlag\\Flag\\vietnam.png");
        }

        private void radioButton_USA_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Flag.Image = new Bitmap("C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\ChangeFlag\\Flag\\usa.png");
        }

        private void radioButton_ITalian_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Flag.Image = new Bitmap("C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\ChangeFlag\\Flag\\italy.png");
        }

        private void radioButton_Philippines_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Flag.Image = new Bitmap("C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\ChangeFlag\\Flag\\philippines.png");
        }
    }
}
