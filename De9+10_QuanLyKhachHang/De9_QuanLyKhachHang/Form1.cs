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
using System.Security.Cryptography;
namespace De9_QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\De9+10_QuanLyKhachHang\\De9_QuanLyKhachHang.mdf\";Integrated Security=True;Connect Timeout=30;");
        int rowindex;
        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaKH AS [STT], HoTen AS [Tên khách hàng], GioiTinh AS [GioiTinh], LoaiPhong AS [Loại phòng], [SoPhongThue] AS [Số phòng cần thuê] FROM KhachHang", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex + 1;
            textBox_TenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
            {
                radioButton_Nam.Checked = true;
            } else if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nữ")
            {
                radioButton_Nu.Checked = true;
            }

            comboBox_LoaiPhong.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_SoPhongThue.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang VALUES (@STT, @TenKH, @GioiTInh, @LoaiPhong, @SoPhongCanThue)", conn);
            cmd.Parameters.AddWithValue("@STT", dataGridView1.RowCount);
            cmd.Parameters.AddWithValue("@TenKH", textBox_TenKH.Text);
            if (radioButton_Nam.Checked )
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nam");
            } else if (radioButton_Nu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nữ");
            }
            cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LoaiPhong.Text);
            cmd.Parameters.AddWithValue("@SoPhongCanThue", textBox_SoPhongThue.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            textBox_TenKH.Clear();
            radioButton_Nam.Checked = false;
            radioButton_Nu.Checked = false;
            comboBox_LoaiPhong.Text = string.Empty;
            textBox_SoPhongThue.Clear();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaKH AS [STT], HoTen AS [Tên khách hàng], GioiTinh AS [GioiTinh], LoaiPhong AS [Loại phòng], SoPhongThue AS [Số phòng cần thuê] FROM KhachHang WHERE HoTen LIKE '%' + @HoTen + '%'", conn);
            cmd.Parameters.AddWithValue("@HoTen", textBox_TKTen.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();

            if (textBox_TKTen.Text == "")
            {
                load();
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET HoTen = @TenKH, GioiTinh = @GioiTinh, LoaiPhong = @LoaiPhong, SoPhongThue = @SoPhongCanThue WHERE MaKH = @STT", conn);
            cmd.Parameters.AddWithValue("@STT", rowindex);
            cmd.Parameters.AddWithValue("@TenKH", textBox_TenKH.Text);
            if (radioButton_Nam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nam");
            }
            else if (radioButton_Nu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTInh", "Nữ");
            }
            cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LoaiPhong.Text);
            cmd.Parameters.AddWithValue("@SoPhongCanThue", textBox_SoPhongThue.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }
    }
}
