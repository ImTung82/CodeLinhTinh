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

namespace _2dgv_QuanLyBanHang
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\QuanLyKhachHang\\QuanLyKhachHang.mdf\";Integrated Security=True;Connect Timeout=30;");
        string ten;
        int gia, stt, sum;

        public Form1()
        {
            InitializeComponent();

            loaditem();
        }

        void loaditem()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT TheLoai FROM List", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            comboBox_TheLoai.Items.Clear();

            while (reader.Read())
            {
                string item = reader[0].ToString();

                if (!comboBox_TheLoai.Items.Contains(item))
                {
                    comboBox_TheLoai.Items.Add(item);
                }
            }

            reader.Close();
            conn.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Control click = contextMenuStrip1.SourceControl;
            contextMenuStrip1.Close();

            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                if (click is Label)
                {
                    click.ForeColor = color.Color;
                } else if (click is DataGridView)
                {
                    DataGridView dgv = (DataGridView)click;
                    dgv.BackgroundColor = color.Color;
                } else
                {
                    click.BackColor = color.Color;
                }
            }
        }

        private void comboBox_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT STT, TenHang AS [Tên hàng], DonGia AS [Đơn giá] FROM List WHERE TheLoai = @TheLoai", conn);
            cmd.Parameters.AddWithValue("@TheLoai", comboBox_TheLoai.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_LoaiHang.DataSource = dt;

            conn.Close();

            label_LoaiHang.Text = comboBox_TheLoai.Text;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            int thanhtien = gia * int.Parse(numericUpDown_SoLuong.Value.ToString());
            dataGridView_DonHang.Rows.Add(dataGridView_DonHang.RowCount, ten, numericUpDown_SoLuong.Value.ToString(), gia, thanhtien);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            dataGridView_DonHang.Rows.RemoveAt(stt);

            foreach (DataGridViewRow row in dataGridView_DonHang.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) >= (stt + 1))
                {
                    row.Cells[0].Value = int.Parse(row.Cells[0].Value.ToString()) - 1;
                }
            }
        }

        private void dataGridView_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ten = dataGridView_LoaiHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            gia = int.Parse(dataGridView_LoaiHang.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button_TaoDon_Click(object sender, EventArgs e)
        {
            comboBox_TheLoai.Text = "";
            textBox_TenKhach.Clear();
            textBox_TongTien.Clear();
            dataGridView_LoaiHang.DataSource = null;
            dataGridView_DonHang.Rows.Clear();
            sum = 0;
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            sum = 0;

            foreach (DataGridViewRow row in dataGridView_DonHang.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    sum += (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString()));
                }
            }

            textBox_TongTien.Text = sum.ToString();
        }

        private void dataGridView_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = e.RowIndex;
        }
    }
}
