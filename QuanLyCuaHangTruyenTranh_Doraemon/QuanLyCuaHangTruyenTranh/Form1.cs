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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCuaHangTruyenTranh
{
    
    public partial class Form1 : Form
    {
        int selectedRowIndex;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Tung_TLU\TLU_Hoc\2023_2024(Nam 2)\Ki_2\Lap Trinh Windows (C#)\Tự học\QuanLyCuaHangTruyenTranh\QuanLyCuaHangTruyenTranh.mdf"";Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
            load();
        }
        

        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM List", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView_ListQuanLy.DataSource = dt;

            conn.Close();
        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar)
            //{
            //    MessageBox.Show("Vui lòng chỉ nhập số!", "Lỗi");
            //    e.Handled = true;
            //}
        }

        private void textBox_SDT_Leave(object sender, EventArgs e)
        {
            double num;

            if (!double.TryParse(textBox_SDT.Text, out num))
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Lỗi");
                textBox_SDT.Clear();
                textBox_SDT.Focus();
            }
        }

        private void dataGridView_ListQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex + 1;
            textBox_TenKhach.Text = dataGridView_ListQuanLy.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_SDT.Text = dataGridView_ListQuanLy.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_TenTruyen.Text = dataGridView_ListQuanLy.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker_NgayMuon.Text = dataGridView_ListQuanLy.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker_NgayTra.Text = dataGridView_ListQuanLy.Rows[e.RowIndex].Cells[5].Value.ToString();

            dateTimePicker_NgayTra.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }
        void LoadDataIntoComboBox()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Truyen", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Xóa tất cả các mục đã có trong ComboBox trước khi thêm mới
            comboBox_TenTruyen.Items.Clear();

            // Đọc từng hàng dữ liệu và thêm vào ComboBox
            while (reader.Read())
            {
                // Đánh chỉ số cột tương ứng với trường mà bạn muốn hiển thị trong ComboBox
                string item = reader["TenTruyen"].ToString();
                comboBox_TenTruyen.Items.Add(item);
            }

            // Đóng đối tượng SqlDataReader và kết nối
            reader.Close();
            conn.Close();
        }

        private void comboBox_TenTruyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT DonGia FROM Truyen WHERE TenTruyen = @TenTruyen", conn);
            cmd.Parameters.AddWithValue("@TenTruyen", comboBox_TenTruyen.Text);

            object result = cmd.ExecuteScalar();
            textBox_DonGia.Text = result.ToString();

            conn.Close();
        }

        private void button_MuonTruyen_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO List (STT, TenKhach, SDT, TenTruyen, NgayMuon, GhiChu) VALUES ('"+dataGridView_ListQuanLy.RowCount.ToString()+"', N'"+textBox_TenKhach.Text+"', '"+textBox_SDT.Text+"', N'"+comboBox_TenTruyen.Text+"', '"+dateTimePicker_NgayMuon.Value.ToString("yyyy-MM-dd") +"', N'Chưa trả')  ", conn);
            comboBox_TenTruyen.Text = "";
            cmd.ExecuteNonQuery();

            conn.Close();

            load();
        }

        private void button_TraTruyen_Click(object sender, EventArgs e)
        {
            conn.Open();

            DateTime muon = dateTimePicker_NgayMuon.Value;
            DateTime tra = dateTimePicker_NgayTra.Value;

            TimeSpan songaymuon = tra - muon;
            int result = songaymuon.Days;

            int sotien = result * (int)decimal.Parse(textBox_DonGia.Text);
         
            SqlCommand cmd = new SqlCommand("UPDATE List SET NgayTra = '"+dateTimePicker_NgayTra.Value.ToString("yyyy-MM-dd") +"', GhiChu = ' ', ThanhTien = @sotien WHERE STT = @selectedRowIndex ", conn);
            cmd.Parameters.AddWithValue("@selectedRowIndex", selectedRowIndex);
            cmd.Parameters.AddWithValue("@sotien", sotien);
            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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

        //private void button_Xoa_Click(object sender, EventArgs e)
        //{
        //    conn.Open();

        //    // Tạo một đối tượng SqlCommand để thực hiện việc chọn dữ liệu
        //    SqlCommand selectcmd = new SqlCommand("SELECT * FROM List", conn);
        //    // Thực thi lệnh và lấy dữ liệu vào SqlDataReader
        //    SqlDataReader reader = selectcmd.ExecuteReader();

        //    List<int> rowsToUpdate = new List<int>(); // Danh sách các dòng cần cập nhật

        //    while (reader.Read())
        //    {
        //        int currentRowIndex = (int)reader["STT"]; // Lấy chỉ số STT của dòng hiện tại
        //        rowsToUpdate.Add(currentRowIndex); // Thêm chỉ số STT vào danh sách

        //        // Đóng DataReader để thực hiện xóa
        //        reader.Close();

        //        // Tạo một đối tượng SqlCommand mới để thực hiện xóa
        //        SqlCommand deletecmd = new SqlCommand("DELETE FROM List WHERE STT = @stt", conn);
        //        deletecmd.Parameters.AddWithValue("@stt", currentRowIndex);
        //        deletecmd.ExecuteNonQuery();

        //        // Cập nhật các chỉ số STT của các dòng còn lại
        //        SqlCommand updatecmd = new SqlCommand("UPDATE List SET STT = STT - 1 WHERE STT > @rowindex", conn);
        //        updatecmd.Parameters.AddWithValue("@rowindex", currentRowIndex);
        //        updatecmd.ExecuteNonQuery();

        //        // Mở lại DataReader để tiếp tục lặp
        //        reader = selectcmd.ExecuteReader();
        //    }

        //    // Đóng DataReader và kết nối
        //    reader.Close();
        //    conn.Close();
        //    load(); // Tải lại dữ liệu vào DataGridView
        //}

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Lấy chỉ số STT của dòng được chọn
            int selectedSTT = int.Parse(dataGridView_ListQuanLy.Rows[selectedRowIndex].Cells["STT"].Value.ToString());

            // Xóa dòng vừa chọn
            SqlCommand deletecmd = new SqlCommand("DELETE FROM List WHERE STT = @stt", conn);
            deletecmd.Parameters.AddWithValue("@stt", selectedSTT);
            deletecmd.ExecuteNonQuery();

            // Cập nhật lại chỉ số STT của các dòng đứng sau
            UpdateSTT(selectedSTT);

            conn.Close();

            // Tải lại dữ liệu vào DataGridView
            load();
        }

        // Phương thức để cập nhật chỉ số STT của các dòng sau khi xóa
        private void UpdateSTT(int deletedRowIndex)
        {
            SqlCommand updatecmd = new SqlCommand("UPDATE List SET STT = STT - 1 WHERE STT > @rowindex", conn);
            updatecmd.Parameters.AddWithValue("@rowindex", deletedRowIndex);
            updatecmd.ExecuteNonQuery();
        }

    }
}
