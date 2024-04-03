using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyQuanInternet
{
    public partial class Form1 : Form
    {
        private Button[] may;
        private TextBox[] giovao;
        private TextBox[] giora;
        private TextBox[] tongtien;
        private Button[] thanhtoan;
 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Tung_TLU\TLU_Hoc\2023_2024(Nam 2)\Ki_2\Lap Trinh Windows (C#)\Tự học\QuanLyQuanInternet\QuanLyQuanInternet.mdf"";");

        void load()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM tb", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        public Form1()
        {
            InitializeComponent();

            load();

            may = new Button[]
            {
                button_May1, button_May2, button_May3, button_May4, button_May5
            };

            giovao = new TextBox[]
            {
                textBox_GioVao1, textBox_GioVao2, textBox_GioVao3, textBox_GioVao4, textBox_GioVao5
            };

            giora = new TextBox[]
            {
                textBox_GioRa1, textBox_GioRa2, textBox_GioRa3, textBox_GioRa4, textBox_GioRa5
            };

            tongtien = new TextBox[]
            {
                textBox_TongTien1, textBox_TongTien2, textBox_TongTien3, textBox_TongTien4, textBox_TongTien5
            };

            thanhtoan = new Button[]
            {
                button_ThanhToan1, button_ThanhToan2, button_ThanhToan3, button_ThanhToan4, button_ThanhToan5
            };
        }

        private void button_May1_Click_1(object sender, EventArgs e)
        {
            int index = Array.IndexOf(may, sender);

            if (giovao[index].Text != "" && giora[index].Text != "") 
            {
                if (may[index].BackColor == Color.Red)
                {
                    MessageBox.Show("Máy đang được dùng", "Thông báo");
                }
                else
                {
                    may[index].BackColor = Color.Red;
                }
            } else
            {
                MessageBox.Show("Nhập giờ đi bạn");
            }
        }

        private void textBox_GioVao1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Lỗi định dạng.");
                e.Handled = true;
            }
        }

        private void textBox_GioRa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = Array.IndexOf(giora, sender);
            MessageBox.Show(index.ToString());
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Lỗi định dạng.");
                e.Handled = true;

                return;
            }

            if (giovao[index].Text != "" && e.KeyChar != (char)Keys.Back)
            {
                int agiovao = int.Parse(giovao[index].Text);
                int agiora = int.Parse(giora[index].Text.ToString() + e.KeyChar);
                tongtien[index].Text = ((agiora - agiovao) * 5000).ToString();
            } else
            {
                tongtien[index].Clear();
            }
        }

        private void button_ThanhToan1_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(thanhtoan, sender);

            if (tongtien[index].Text != "")
            {
                conn.Open();
              
                if (may[index].BackColor == Color.Red)
                {
                    int giosudung = (int.Parse(giora[index].Text) - int.Parse(giovao[index].Text));
                    SqlCommand cmd = new SqlCommand("INSERT INTO tb VALUES ('" + dataGridView1.RowCount.ToString() + "', '" + may[index].Text + "', '" + giovao[index].Text + "', '" + giora[index].Text + "', '" + giosudung + "', N' 5000đ / giờ ', '" + tongtien[index].Text + "')   ", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                } else
                {
                    giovao[index].Clear();
                    giora[index].Clear();

                    conn.Close();
                }

                load();

                may[index].BackColor = Color.LightGray;
                giovao[index].Clear();
                giora[index].Clear();
                tongtien[index].Clear();
            }
        }
    }
}
