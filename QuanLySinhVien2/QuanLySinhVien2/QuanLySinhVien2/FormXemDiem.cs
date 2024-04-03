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
    public partial class FormXemDiem : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Downloads\QuanLySinhVien2\QuanLySinhVien2\dbQuanLySinhVien2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader rdr;
        SqlCommand cmd;

        public FormXemDiem()
        {
            InitializeComponent();
            PushData();
        }

        public void PushData()
        {
            dgvData.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT MaSo, HoTen FROM tbSinhVien", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                boxMaSo.Items.Add(rdr[0]);
                boxTenSV.Items.Add(rdr[1]);
            }
            rdr.Close();
            conn.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (boxMaSo.Text == "" || boxTenSV.Text == "" || txtKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                dgvData.Rows.Clear();
                conn.Open();
                cmd = new SqlCommand("SELECT TenMH, Diem FROM tbMon " +
                    "INNER JOIN tbKetQua ON tbMon.MaMH = tbKetQua.MaMH " +
                    "INNER JOIN tbSinhVien ON tbSinhVien.MaSo = tbKetQua.MaSo " +
                    "INNER JOIN tbKhoa ON tbSinhVien.MaKhoa = tbKhoa.MaKhoa " +
                    "WHERE (tbSinhVien.MaSo = @maso) AND (tbSinhVien.HoTen = @tensv) AND (tbKhoa.TenKhoa LIKE @tenkhoa + '%')", conn);

                cmd.Parameters.AddWithValue("@maso", boxMaSo.Text);
                cmd.Parameters.AddWithValue("@tensv", boxTenSV.Text);
                cmd.Parameters.AddWithValue("@tenkhoa", txtKhoa.Text);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dgvData.Rows.Add(rdr[0], rdr[1]);
                }
                conn.Close();
            }
        }
    }
}
