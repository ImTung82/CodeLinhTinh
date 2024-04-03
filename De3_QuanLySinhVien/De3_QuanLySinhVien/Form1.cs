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

namespace De3_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Tung_TLU\\TLU_Hoc\\2023_2024(Nam 2)\\Ki_2\\Lap Trinh Windows (C#)\\Tự học\\De3_QuanLySinhVien\\De3_QuanLySinhVien.mdf\";Integrated Security=True;Connect Timeout=30;");
        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MaSV AS [Mã SV], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], NoiSinh AS [Nơi sinh] FROM List", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_List.DataSource = dt;

            conn.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO List VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh)", conn);
            cmd.Parameters.AddWithValue("@MaSV", textBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@HoTen", textBox_HoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value.ToString("yyyy-MM-dd"));
            
            if (radioButton_Nam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            } else if (radioButton_Nu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }

            cmd.Parameters.AddWithValue("@NoiSinh", comboBox_NoiSinh.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            textBox_MaSV.Clear();
            textBox_HoTen.Clear();

            //// Set thành 1/1/1753
            //dateTimePicker_NgaySinh.Value = DateTimePicker.MinimumDateTime;

            DateTime dt = new DateTime(2000, 1, 1);
            dateTimePicker_NgaySinh.Value = dt;

            comboBox_NoiSinh.Text = "";
            if (radioButton_Nam.Checked)
            {
                radioButton_Nam.Checked = false;
            } else if (radioButton_Nu.Checked)
            {
                radioButton_Nu.Checked = false;
            }
        }

        private void dgv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaSV.Text = dgv_List.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_HoTen.Text = dgv_List.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_NgaySinh.Text = dgv_List.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_NoiSinh.Text = dgv_List.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dgv_List.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                radioButton_Nam.Checked = true;
            } else if (dgv_List.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nữ")
            {
                radioButton_Nu.Checked = true;
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE List SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh WHERE MaSV = @MaSV", conn);
            cmd.Parameters.AddWithValue("@MaSV", textBox_MaSV.Text);
            cmd.Parameters.AddWithValue("@HoTen", textBox_HoTen.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value.ToString("yyyy-MM-dd"));

            if (radioButton_Nam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            }
            else if (radioButton_Nu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }

            cmd.Parameters.AddWithValue("@NoiSinh", comboBox_NoiSinh.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM List WHERE MaSV = @MaSV", conn);
            cmd.Parameters.AddWithValue("@MaSV", textBox_MaSV.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void button_Loc_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.ShowDialog();
        }
    }
}
