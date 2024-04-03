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
using System.Drawing.Printing;

namespace De7_ThanhToan
{
    public partial class frmThanhToan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\De7+8_QuanLyCafe\\QLCAFE.mdf\";Integrated Security=True;Connect Timeout=30;");

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT SoBan AS [Số bàn], DoUong AS [Tên Đồ uống], SoLuong AS [Số lượng], Gia AS [Giá] FROM DATHANG WHERE SoBan = @SoBan", conn);
            cmd.Parameters.AddWithValue("@SoBan", comboBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Số lượng"].Value != null && row.Cells["Giá"].Value != null)
                {
                    int soluong, gia;
                    if (int.TryParse(row.Cells["Số lượng"].Value.ToString(), out soluong) && int.TryParse(row.Cells["Giá"].Value.ToString(), out gia))
                    {
                        sum += (soluong * gia);
                    }
                }
            }

            textBox_ThanhTien.Text = sum.ToString();

            conn.Close();
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            if (checkBox_DoUong.Checked && checkBox_NgayThang.Checked)
            {
                int sum = 0;

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SoBan AS [Số bàn], DoUong AS [Tên Đồ uống], SoLuong AS [Số lượng], Gia AS [Giá], Ngay AS [Ngày] FROM DATHANG WHERE DoUong = @DoUong AND Ngay BETWEEN @TuNgay AND @DenNgay", conn);
                cmd.Parameters.AddWithValue("@DoUong", comboBox_DoUong.Text);
                cmd.Parameters.AddWithValue("@TuNgay", dateTimePicker_TuNgay.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@DenNGay", dateTimePicker_DenNgay.Value.ToString("yyyy-MM-dd"));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Số lượng"].Value != null && row.Cells["Giá"].Value != null)
                    {
                        int soluong, gia;
                        if (int.TryParse(row.Cells["Số lượng"].Value.ToString(), out soluong) && int.TryParse(row.Cells["Giá"].Value.ToString(), out gia))
                        {
                            sum += (soluong * gia);
                        }
                    }
                }

                textBox_DoanhThu.Text = sum.ToString();

                conn.Close();
            }
            else if (checkBox_DoUong.Checked)
            {
                int sum = 0;

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SoBan AS [Số bàn], DoUong AS [Tên Đồ uống], SoLuong AS [Số lượng], Gia AS [Giá], Ngay AS [Ngày] FROM DATHANG WHERE DoUong = @DoUong", conn);
                cmd.Parameters.AddWithValue("@DoUong", comboBox_DoUong.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Số lượng"].Value != null && row.Cells["Giá"].Value != null)
                    {
                        int soluong, gia;
                        if (int.TryParse(row.Cells["Số lượng"].Value.ToString(), out soluong) && int.TryParse(row.Cells["Giá"].Value.ToString(), out gia))
                        {
                            sum += (soluong * gia);
                        }
                    }
                }

                textBox_DoanhThu.Text = sum.ToString();

                conn.Close();
            }
            else if (checkBox_NgayThang.Checked)
            {
                int sum = 0;

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SoBan AS [Số bàn], DoUong AS [Tên Đồ uống], SoLuong AS [Số lượng], Gia AS [Giá], Ngay AS [Ngày] FROM DATHANG WHERE Ngay BETWEEN @TuNgay AND @DenNgay", conn);
                cmd.Parameters.AddWithValue("@TuNgay", dateTimePicker_TuNgay.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@DenNGay", dateTimePicker_DenNgay.Value.ToString("yyyy-MM-dd"));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["Số lượng"].Value != null && row.Cells["Giá"].Value != null)
                    {
                        int soluong, gia;
                        if (int.TryParse(row.Cells["Số lượng"].Value.ToString(), out soluong) && int.TryParse(row.Cells["Giá"].Value.ToString(), out gia))
                        {
                            sum += (soluong * gia);
                        }
                    }
                }

                textBox_DoanhThu.Text = sum.ToString();

                conn.Close();
            } else
            {
                comboBox_DoUong.Text = "";
                dateTimePicker_TuNgay.Value = DateTime.Now;
                dateTimePicker_DenNgay.Value = DateTime.Now;
                dataGridView2.DataSource = null;
                textBox_DoanhThu.Clear();
            }
        }
    }
}
