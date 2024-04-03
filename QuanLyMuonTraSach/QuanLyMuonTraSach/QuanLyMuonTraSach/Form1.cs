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

namespace QuanLyMuonTraSach
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - Thuyloi University\Tài liệu\dbMuonSach.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlDataReader rdr;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            LoadData(dgvSach, "tbSach");
            LoadData(dgvMuonSach, "tbMuonSach");
            PushDataSach();
            dateTra.Enabled = false;
            dateTra.Text = "";
        }
        
        public void LoadData(DataGridView dgv, string tenbang) 
        {
            int i = 0;
            dgv.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand($"SELECT * FROM {tenbang}", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (dgv.Name == "dgvSach")
                {
                    dgv.Rows.Add(rdr[0], rdr[1]);
                }
                else
                {
                    i++;
                    dgv.Rows.Add(i, rdr[1], rdr[2] ,rdr[3], rdr[4], rdr[5]);
                }
            }
            rdr.Close();
            conn.Close();
        }

        public void PushDataSach()
        {
            boxTenSach.Items.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM tbSach", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                boxTenSach.Items.Add(rdr[1]);
            }
            rdr.Close();
            conn.Close();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tbSach VALUES (@masach, @tensach)", conn);
                    cmd.Parameters.AddWithValue("@masach", txtMaSach.Text);
                    cmd.Parameters.AddWithValue("@tensach", txtTenSach.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData(dgvSach, "tbSach");
                    PushDataSach();
                }
                catch
                {
                    MessageBox.Show("Đã có mã sách này trong hệ thống", "Thông báo");
                    conn.Close();
                }
            }
            
        }

        private void dateMuon_ValueChanged(object sender, EventArgs e)
        {
            if (dateMuon.Enabled == false)
            {
                return;
            }

            dateTra.Value = dateMuon.Value.AddDays(40);
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (boxTenSV.Text == "" || boxTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }

            if (dateMuon.Value > dateTra.Value)
            {
                MessageBox.Show("Ngày nhập không hợp lệ", "Thông báo");
            }

            else
            {
                int id;
                conn.Open();
                cmd = new SqlCommand("SELECT COUNT(id) FROM tbMuonSach", conn);
                id = (int)cmd.ExecuteScalar() + 1;
                cmd = new SqlCommand($"INSERT INTO tbMuonSach VALUES ({id}, @hoten, @tensach, @ngaymuon, @ngaytra, @thanhtien)", conn);
                cmd.Parameters.AddWithValue("@hoten", boxTenSV.Text);
                cmd.Parameters.AddWithValue("@tensach", boxTenSach.Text);
                cmd.Parameters.AddWithValue("@ngaymuon", dateMuon.Value.Date);
                cmd.Parameters.AddWithValue("@ngaytra", dateTra.Value.Date);
                cmd.Parameters.AddWithValue("@thanhtien", 0);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData(dgvMuonSach, "tbMuonSach");
            }
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boxTenSV.Text = dgvMuonSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            boxTenSach.Text = dgvMuonSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateMuon.Text = dgvMuonSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTra.Text = dgvMuonSach.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTra.Enabled = true;
            dateMuon.Enabled = false;
            boxTenSV.Enabled = false;
            boxTenSach.Enabled = false;
        }

        private void dateTra_ValueChanged(object sender, EventArgs e)
        {
            if (dateTra.Enabled == false)
            {
                return;
            }
            DateTime muon = dateMuon.Value;
            DateTime tra = dateTra.Value;
            TimeSpan songay = tra - muon;
            lbSoNgay.Text = songay.Days.ToString();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (dateMuon.Value > dateTra.Value)
            {
                MessageBox.Show("Ngày nhập không hợp lệ", "Thông báo");
            }
            else
            {
                int thanhtien = 0;
                int songay = int.Parse(lbSoNgay.Text);
                if (songay > 40)
                {
                    thanhtien = (songay - 40) * 2000;
                }

                int id;
                conn.Open();
                cmd = new SqlCommand("SELECT id FROM tbMuonSach WHERE hoten = @hoten AND tensach = @tensach", conn);
                cmd.Parameters.AddWithValue("@hoten", boxTenSV.Text);
                cmd.Parameters.AddWithValue("@tensach", boxTenSach.Text);
                id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"UPDATE tbMuonSach SET ngaytra = @ngaytra, thanhtien = @thanhtien WHERE id = {id}", conn);
                cmd.Parameters.AddWithValue("@ngaytra", dateTra.Value.Date);
                cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData(dgvMuonSach, "tbMuonSach");
            }
        }
    }
}
