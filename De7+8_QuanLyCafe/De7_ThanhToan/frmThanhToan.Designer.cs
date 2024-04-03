namespace De7_ThanhToan
{
    partial class frmThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DoanhThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_DoUong = new System.Windows.Forms.ComboBox();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.checkBox_NgayThang = new System.Windows.Forms.CheckBox();
            this.checkBox_DoUong = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hệ thống";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đồ uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bàn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thanh toán";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox_ThanhTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 485);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5",
            "Bàn 6",
            "Bàn 7",
            "Bàn 8",
            "Bàn 9",
            "Bàn 10"});
            this.comboBox1.Location = new System.Drawing.Point(9, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 390);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Enabled = false;
            this.textBox_ThanhTien.Location = new System.Drawing.Point(625, 441);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(156, 20);
            this.textBox_ThanhTien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(311, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.textBox_DoanhThu);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Thống kê";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(712, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "(VNĐ)";
            // 
            // textBox_DoanhThu
            // 
            this.textBox_DoanhThu.Enabled = false;
            this.textBox_DoanhThu.Location = new System.Drawing.Point(521, 452);
            this.textBox_DoanhThu.Name = "textBox_DoanhThu";
            this.textBox_DoanhThu.Size = new System.Drawing.Size(185, 20);
            this.textBox_DoanhThu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doanh thu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(778, 219);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_DenNgay);
            this.groupBox1.Controls.Add(this.dateTimePicker_TuNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_DoUong);
            this.groupBox1.Controls.Add(this.button_ThongKe);
            this.groupBox1.Controls.Add(this.checkBox_NgayThang);
            this.groupBox1.Controls.Add(this.checkBox_DoUong);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc thông tin";
            // 
            // dateTimePicker_DenNgay
            // 
            this.dateTimePicker_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DenNgay.Location = new System.Drawing.Point(398, 92);
            this.dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
            this.dateTimePicker_DenNgay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DenNgay.TabIndex = 7;
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(146, 92);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_TuNgay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ ngày";
            // 
            // comboBox_DoUong
            // 
            this.comboBox_DoUong.FormattingEnabled = true;
            this.comboBox_DoUong.Items.AddRange(new object[] {
            "Nâu đá",
            "Bạc sỉu",
            "Cà phê cốt dừa"});
            this.comboBox_DoUong.Location = new System.Drawing.Point(146, 34);
            this.comboBox_DoUong.Name = "comboBox_DoUong";
            this.comboBox_DoUong.Size = new System.Drawing.Size(200, 21);
            this.comboBox_DoUong.TabIndex = 3;
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.BackColor = System.Drawing.Color.LightGray;
            this.button_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongKe.Location = new System.Drawing.Point(271, 141);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(75, 23);
            this.button_ThongKe.TabIndex = 2;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.UseVisualStyleBackColor = false;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // checkBox_NgayThang
            // 
            this.checkBox_NgayThang.AutoSize = true;
            this.checkBox_NgayThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_NgayThang.Location = new System.Drawing.Point(43, 92);
            this.checkBox_NgayThang.Name = "checkBox_NgayThang";
            this.checkBox_NgayThang.Size = new System.Drawing.Size(78, 17);
            this.checkBox_NgayThang.TabIndex = 1;
            this.checkBox_NgayThang.Text = "Ngày tháng";
            this.checkBox_NgayThang.UseVisualStyleBackColor = true;
            // 
            // checkBox_DoUong
            // 
            this.checkBox_DoUong.AutoSize = true;
            this.checkBox_DoUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_DoUong.Location = new System.Drawing.Point(43, 36);
            this.checkBox_DoUong.Name = "checkBox_DoUong";
            this.checkBox_DoUong.Size = new System.Drawing.Size(64, 17);
            this.checkBox_DoUong.TabIndex = 0;
            this.checkBox_DoUong.Text = "Đồ uống";
            this.checkBox_DoUong.UseVisualStyleBackColor = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_DoUong;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.CheckBox checkBox_NgayThang;
        private System.Windows.Forms.CheckBox checkBox_DoUong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

