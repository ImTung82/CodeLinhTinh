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

namespace QuanLyQuanCafe
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\QuanLyQuanCafe\\QuanLyQuanCafe.mdf\";Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;

        Dictionary<string, int> listdouong = new Dictionary<string, int>()
        {
            {"Bạc sỉu", 30000},
            {"Matcha đá xay", 50000},
            {"Cà phê cốt dừa", 40000},
            {"Sữa chua đánh đá", 30000},
            {"Latte", 45000}
        };
        int thanhtien;

        void load()
        {
            conn.Open();

            cmd = new SqlCommand("SELECT SoBan, TenDoUong, GhiChu, SoLuong, ThanhTien FROM Ban WHERE SoBan = @SoBan", conn);
            cmd.Parameters.AddWithValue("@SoBan", comboBox_Ban.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();

            foreach (var item in listdouong.Keys)
            {
                comboBox_DoUong.Items.Add(item);
            }
        }

        private void comboBox_DoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Gia.Text = listdouong[comboBox_DoUong.Text].ToString();
        }

        private void comboBox_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            thanhtien = 0;
            conn.Open();

            cmd = new SqlCommand("SELECT SoBan, TenDoUong, GhiChu, SoLuong, ThanhTien FROM Ban WHERE SoBan = @SoBan", conn);
            cmd.Parameters.AddWithValue("@SoBan", comboBox_Ban.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value != null)
                {
                    thanhtien += int.Parse(row.Cells[4].Value.ToString());
                }
            }
            textBox_ThanhTien.Text = thanhtien.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            comboBox_DoUong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Gia.Text = listdouong[comboBox_DoUong.Text].ToString();
            richTextBox_GhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericUpDown_SoLuong.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("INSERT INTO Ban VALUES (@SoBan, @TenDoUong, @GhiChu, @SoLuong, @ThanhTien)", conn);
                cmd.Parameters.AddWithValue("@SoBan", comboBox_Ban.Text);
                cmd.Parameters.AddWithValue("@TenDoUong", comboBox_DoUong.Text);
                cmd.Parameters.AddWithValue("@GhiChu", richTextBox_GhiChu.Text);
                cmd.Parameters.AddWithValue("@SoLuong", numericUpDown_SoLuong.Value.ToString());
                cmd.Parameters.AddWithValue("@ThanhTien", (int.Parse(textBox_Gia.Text) * int.Parse(numericUpDown_SoLuong.Value.ToString())));
                cmd.ExecuteNonQuery();

                conn.Close();
                load();
            }
            catch 
            {
                conn.Close();
                MessageBox.Show("Bàn đã có đồ uống trên, vui lòng sửa lại số lượng đồ uống nếu bạn muốn thay đổi thông tin", "Lỗi");
            }

            thanhtien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    thanhtien += int.Parse(row.Cells[4].Value.ToString());
                }
            }
            textBox_ThanhTien.Text = thanhtien.ToString();

            comboBox_DoUong.Text = "";
            richTextBox_GhiChu.Clear();
            numericUpDown_SoLuong.Value = 0;
            textBox_Gia.Clear();
        }

        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            thanhtien = 0;
            conn.Open();

            cmd = new SqlCommand("UPDATE Ban SET GhiChu = @GhiChu, SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE SoBan = @SoBan AND TenDoUong = @TenDoUong", conn);
            cmd.Parameters.AddWithValue("@SoBan", comboBox_Ban.Text);
            cmd.Parameters.AddWithValue("@TenDoUong", comboBox_DoUong.Text);
            cmd.Parameters.AddWithValue("@GhiChu", richTextBox_GhiChu.Text);
            cmd.Parameters.AddWithValue("@SoLuong", numericUpDown_SoLuong.Value.ToString());
            cmd.Parameters.AddWithValue("@ThanhTien", (int.Parse(textBox_Gia.Text) * int.Parse(numericUpDown_SoLuong.Value.ToString())));
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    thanhtien += int.Parse(row.Cells[4].Value.ToString());
                }
            }
            textBox_ThanhTien.Text = thanhtien.ToString();

            comboBox_DoUong.Text = "";
            richTextBox_GhiChu.Clear();
            numericUpDown_SoLuong.Value = 0;
            textBox_Gia.Clear();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            thanhtien = 0;
            conn.Open();

            cmd = new SqlCommand("DELETE FROM Ban WHERE SoBan = @SoBan AND TenDoUong = @TenDoUong", conn);
            cmd.Parameters.AddWithValue("@SoBan", comboBox_Ban.Text);
            cmd.Parameters.AddWithValue("@TenDoUong", comboBox_DoUong.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    thanhtien += int.Parse(row.Cells[4].Value.ToString());
                }
            }
            textBox_ThanhTien.Text = thanhtien.ToString();

            comboBox_DoUong.Text = "";
            richTextBox_GhiChu.Clear();
            numericUpDown_SoLuong.Value = 0;
            textBox_Gia.Clear();
        }
    }
}
