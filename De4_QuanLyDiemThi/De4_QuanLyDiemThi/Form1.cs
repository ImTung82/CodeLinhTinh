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

namespace De4_QuanLyDiemThi
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\De4_QuanLyDiemThi\\De4_2.mdf\";Integrated Security=True;Connect Timeout=30;");
        Dictionary<string, string> listgoc = new Dictionary<string, string>()
        {
            { "1", "Tùng" },
            { "2", "Việt" },
            { "3", "Trường" }
        };
        public Form1()
        {
            InitializeComponent();
            load();

            foreach (var i in listgoc)
            {
                comboBox_MaSV.Items.Add(i.Key);
            }
        }

        void load()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], DiemToan AS [Điểm toán], DiemVan AS [Điểm văn], DiemNgoaiNgu AS [Điểm ngoại ngữ], DiemTrungBinh AS [Điểm trung bình] FROM List", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_List.DataSource = dt;

            conn.Close();
        }

        private void comboBox_MaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox_MaSV.Text;
            textBox_HoTenSV.Text = listgoc[key];
            textBox_HoTenSV.Enabled = false;
        }

        private void textBox_DiemToan_Leave(object sender, EventArgs e)
        {
            float diem;

            if (float.TryParse(textBox_DiemToan.Text, out diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Vui lòng nhập điểm trong khoảng [0, 10]", "Lỗi");
                    textBox_DiemToan.Clear();
                    textBox_DiemToan.Focus();
                }
            } else if (textBox_DiemToan.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi");
                textBox_DiemToan.Clear();
                textBox_DiemToan.Focus();
            }
        }

        private void textBox_DiemVan_TextChanged(object sender, EventArgs e)
        {
            float diem;

            if (float.TryParse(textBox_DiemVan.Text, out diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Vui lòng nhập điểm trong khoảng [0, 10]", "Lỗi");
                    textBox_DiemVan.Clear();
                    textBox_DiemVan.Focus();
                }
            }
            else if (textBox_DiemVan.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi");
                textBox_DiemVan.Clear();
                textBox_DiemVan.Focus();
            }
        }

        private void textBox_DiemNN_TextChanged(object sender, EventArgs e)
        {
            float diem;

            if (float.TryParse(textBox_DiemNN.Text, out diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Vui lòng nhập điểm trong khoảng [0, 10]", "Lỗi");
                    textBox_DiemNN.Clear();
                    textBox_DiemNN.Focus();
                }
            }
            else if (textBox_DiemNN.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi");
                textBox_DiemNN.Clear();
                textBox_DiemNN.Focus();
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO List VALUES (@MaSV, @HoTen, @DiemToan, @DiemVan, @DiemNN, @DiemTB)", conn);
            cmd.Parameters.AddWithValue("@MaSV", comboBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@HoTen", textBox_HoTenSV.Text);
            cmd.Parameters.AddWithValue("@DiemToan", textBox_DiemToan.Text);
            cmd.Parameters.AddWithValue("@DiemVan", textBox_DiemVan.Text);
            cmd.Parameters.AddWithValue("@DiemNN", textBox_DiemNN.Text);

            float diemtb = (float.Parse(textBox_DiemToan.Text) + float.Parse(textBox_DiemVan.Text) + float.Parse(textBox_DiemNN.Text)) / 3;

            cmd.Parameters.AddWithValue("@DiemTB", diemtb);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void dataGridView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_MaSV.Text = dataGridView_List.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_HoTenSV.Text = dataGridView_List.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_DiemToan.Text = dataGridView_List.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_DiemVan.Text = dataGridView_List.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_DiemNN.Text = dataGridView_List.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            textBox_HoTenSV.Enabled = false;
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE List SET DiemToan = @DiemToan, DiemVan = @DiemVan, DiemNgoaiNgu = @DiemNN, DiemTrungBinh = @DiemTB WHERE MaSV = @MaSV", conn);
            cmd.Parameters.AddWithValue("MaSV", comboBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@DiemToan", textBox_DiemToan.Text);
            cmd.Parameters.AddWithValue("@DiemVan", textBox_DiemVan.Text);
            cmd.Parameters.AddWithValue("@DiemNN", textBox_DiemNN.Text);

            float diemtb = (float.Parse(textBox_DiemToan.Text) + float.Parse(textBox_DiemVan.Text) + float.Parse(textBox_DiemNN.Text)) / 3;

            cmd.Parameters.AddWithValue("@DiemTB", diemtb);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM List WHERE MaSV = @MaSV", conn);
            cmd.Parameters.AddWithValue("@MaSV", comboBox_MaSV.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
            comboBox_MaSV.Text = "";
            textBox_HoTenSV.Clear();
            textBox_DiemToan.Clear();
            textBox_DiemVan.Clear();
            textBox_DiemNN.Clear();
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            if (comboBox_ThongKe.Text == "Sinh viên đạt loại Giỏi")
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], DiemToan AS [Điểm toán], DiemVan AS [Điểm văn], DiemNgoaiNgu AS [Điểm ngoại ngữ], DiemTrungBinh AS [Điểm trung bình] FROM List WHERE DiemTrungBinh >= 8", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            } else if (comboBox_ThongKe.Text == "Sinh viên đạt loại Khá")
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], DiemToan AS [Điểm toán], DiemVan AS [Điểm văn], DiemNgoaiNgu AS [Điểm ngoại ngữ], DiemTrungBinh AS [Điểm trung bình] FROM List WHERE (DiemTrungBinh < 8 AND DiemTrungBinh >= 6.5)", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            } else
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], DiemToan AS [Điểm toán], DiemVan AS [Điểm văn], DiemNgoaiNgu AS [Điểm ngoại ngữ], DiemTrungBinh AS [Điểm trung bình] FROM List WHERE DiemTrungBinh < 6.5", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_ThongKe.DataSource = dt;

                conn.Close();
            }
        }
    }
}
