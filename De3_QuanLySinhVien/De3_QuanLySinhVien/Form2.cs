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

namespace De3_QuanLySinhVien
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\De3_QuanLySinhVien\\De3_QuanLySinhVien.mdf\";Integrated Security=True;Connect Timeout=30;");
        public Form2()
        {
            InitializeComponent();
        }

        private void button_TKMaSV_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], NoiSinh AS [Nơi sinh] FROM List WHERE MaSV = @MaSV", conn);
            cmd.Parameters.AddWithValue("@MaSV", textBox_TKMaSV.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_List2.DataSource = dt;

            conn.Close();
            textBox_TKMaSV.Clear();
        }

        private void button_TKNoiSinh_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], NoiSinh AS [Nơi sinh] FROM List WHERE NoiSinh = @NoiSinh", conn);
            cmd.Parameters.AddWithValue("@NoiSinh", comboBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_List2.DataSource = dt;

            conn.Close();
            comboBox1.Text = "";
        }

        private void button_TKGioiTinh_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], NoiSinh AS [Nơi sinh] FROM List WHERE GioiTinh = @GioiTinh", conn);
            
            if (radioButton_TKNam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nam");
                radioButton_TKNam.Checked = false;
            } else if (radioButton_TKNu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nữ");
                radioButton_TKNu.Checked = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_List2.DataSource = dt;

            conn.Close();
        }
    }
}
