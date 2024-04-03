using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\QuanLyKhachHang\\QuanLyKhachHang.mdf\";Integrated Security=True;Connect Timeout=30;");
        Dictionary<string, int> listhang = new Dictionary<string, int>()
        {
            {"Táo", 20000},
            {"Nho", 50000},
            {"Lê", 30000},
            {"Xoài", 15000},
            {"Bưởi", 20000}
        };
        int tongtien = 0;
        int rowindex;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_LoaiHoaQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_DonGia.Text = listhang[comboBox_LoaiHoaQua.Text].ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            int thanhtien = (int.Parse(textBox_DonGia.Text) * int.Parse(numericUpDown_SoLuong.Value.ToString()));

            dataGridView1.Rows.Add(dataGridView1.RowCount, comboBox_LoaiHoaQua.Text, textBox_DonGia.Text, numericUpDown_SoLuong.Value.ToString(), thanhtien);
            tongtien += thanhtien;

            textBox_TongTienPhaiTra.Text = tongtien.ToString();

            comboBox_LoaiHoaQua.Text = string.Empty;
            textBox_DonGia.Clear();
            numericUpDown_SoLuong.Value = 0;
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            tongtien -= int.Parse(dataGridView1.Rows[rowindex - 1].Cells[4].Value.ToString());
            textBox_TongTienPhaiTra.Text = tongtien.ToString();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) >= rowindex)
                {
                    row.Cells[0].Value = (int.Parse(row.Cells[0].Value.ToString()) - 1).ToString();
                }
            }

            dataGridView1.Rows.RemoveAt(rowindex - 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex + 1;
        }

        private void textBox_SoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_SoTienKhachDua.Text, out int tienkhachdua) && textBox_SoTienKhachDua.Text != "")
            {
                MessageBox.Show("Lỗi định dạng khi nhập vào", "Lỗi");
                textBox_SoTienKhachDua.Text = string.Empty;
            } else
            {
                textBox_SoTienTraLai.Text = (tienkhachdua - tongtien).ToString();
            }
        }

        private void button_HoanThanh_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            dataGridView1.Rows.Clear();
            textBox_TongTienPhaiTra.Clear();
            textBox_SoTienKhachDua.Clear();
            textBox_TongTienPhaiTra.Clear();
        }
    }
}
