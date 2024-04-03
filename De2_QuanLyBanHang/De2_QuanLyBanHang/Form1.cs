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

namespace De2_QuanLyBanHang
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Tung_TLU\TLU_Hoc\2023_2024(Nam 2)\Ki_2\Lap Trinh Windows (C#)\Tự học\De2_QuanLyBanHang\De2_QuanLyBanHang.mdf"";Integrated Security=True;Connect Timeout=30;");
        int rowindex;
        public Form1()
        {
            InitializeComponent();
            load();

            foreach(var item in listhang.Keys)
            {
                comboBox_DonHang.Items.Add(item);
            }
        }

        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM List", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView_List.DataSource = dt;

            conn.Close();
        }

        #region Từ điển

        /*
         * Cấu trúc: 
           Dictionary <[kiểu DL 1], [kiểu DL 2]> [tên từ điển] = new Dictionary <[kiểu DL 1], [kiểu DL 2]>() 
           {
                { [DL 1], [DL 2] },
                { [...], [...]}
           }

         * - DL 1 (Key), tương ứng với DL 2 (Value) tạo thành 1 cặp, ví dụ: { "Táo", 10 } --> Key "Táo" sẽ có Value là 10
         */

        #endregion
        Dictionary<string, int> listhang = new Dictionary<string, int>()
        {
            { "Táo", 10 },
            { "Bánh", 20},
            { "Nho", 100 },
            { "Manga", 40 },
            { "Light Novel", 140 }
        };

        private void button_TaoDonHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM List", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void comboBox_DonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_DonGia.Text = listhang[comboBox_DonHang.Text].ToString();

            //string tenhangduocchon = comboBox_DonHang.Text;
            //textBox_DonGia.Text = listhang[tenhangduocchon].ToString();
        }

        private void button_Nhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO List VALUES (@STT, @TenHang, @SoLuong, @DonGia, @ThanhTien)", conn);
            cmd.Parameters.AddWithValue("@STT", dataGridView_List.RowCount.ToString());
            cmd.Parameters.AddWithValue("@TenHang", comboBox_DonHang.Text);
            cmd.Parameters.AddWithValue("@SoLuong", numericUpDown_SoLuong.Value.ToString());
            cmd.Parameters.AddWithValue("@DonGia", textBox_DonGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", (numericUpDown_SoLuong.Value * int.Parse(textBox_DonGia.Text)).ToString());
            cmd.ExecuteNonQuery();

            conn.Close();
            load();

            textBox_TenKhach.Clear();
            comboBox_DonHang.Text = "";
            numericUpDown_SoLuong.Value = 0;
            textBox_DonGia.Clear();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand deletecmd = new SqlCommand("DELETE FROM List WHERE STT = @STT", conn);
            deletecmd.Parameters.AddWithValue("@STT", rowindex);
            deletecmd.ExecuteNonQuery();

            SqlCommand updatecmd = new SqlCommand("UPDATE List SET STT = STT - 1 WHERE STT > @STT", conn);
            updatecmd.Parameters.AddWithValue("@STT", rowindex);
            updatecmd.ExecuteNonQuery();

            conn.Close();
            load();
        }

        private void dataGridView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex + 1;
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(ThanhTien) FROM List", conn);
            object tongtien = cmd.ExecuteScalar();
            textBox_TongTien.Text = tongtien.ToString(); 
            conn.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Control clickedControl = ContextMenuStrip.SourceControl;

            contextMenuStrip1.Close();
            ColorDialog chonmau = new ColorDialog();
            if (chonmau.ShowDialog() == DialogResult.OK)
            {
                if (clickedControl is Label)
                {
                    clickedControl.ForeColor = chonmau.Color;
                }
                else if (clickedControl is DataGridView)
                {
                    DataGridView dgv = (DataGridView)clickedControl;
                    dgv.BackgroundColor = chonmau.Color;
                }
                else
                {
                    clickedControl.BackColor = chonmau.Color;
                }
            }
        }
    }
 }