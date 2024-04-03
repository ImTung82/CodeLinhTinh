using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien2
{
    public partial class FormKhoa : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Downloads\QuanLySinhVien2\QuanLySinhVien2\dbQuanLySinhVien2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader rdr;
        SqlCommand cmd;

        public FormKhoa()
        {
            InitializeComponent();
            LoadData();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        public void LoadData()
        {
            dgvData.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM tbKhoa", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dgvData.Rows.Add(rdr[0], rdr[1]);
            }
            rdr.Close();
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tbKhoa VALUES (@makhoa, @tenkhoa)", conn);
                    cmd.Parameters.AddWithValue("@makhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@tenkhoa", txtTenKhoa.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Đã tồn tại mã khoa này!", "Thông báo");
                    conn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM tbKhoa WHERE MaKhoa = @makhoa", conn);
            cmd.Parameters.AddWithValue("@makhoa", txtMaKhoa.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();

            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKhoa.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhoa.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE tbKhoa SET TenKhoa = @tenkhoa WHERE MaKhoa = @makhoa", conn);
                cmd.Parameters.AddWithValue("@makhoa", txtMaKhoa.Text);
                cmd.Parameters.AddWithValue("@tenkhoa", txtTenKhoa.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }
        }
    }
}
