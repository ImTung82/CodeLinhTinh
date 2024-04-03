namespace QuanLyKhachHang
{
    partial class Form1
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
            this.comboBox_LoaiHoaQua = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_TongTienPhaiTra = new System.Windows.Forms.TextBox();
            this.textBox_SoTienTraLai = new System.Windows.Forms.TextBox();
            this.textBox_SoTienKhachDua = new System.Windows.Forms.TextBox();
            this.button_HoanThanh = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_LoaiHoaQua
            // 
            this.comboBox_LoaiHoaQua.FormattingEnabled = true;
            this.comboBox_LoaiHoaQua.Items.AddRange(new object[] {
            "Táo",
            "Nho",
            "Lê",
            "Xoài",
            "Bưởi"});
            this.comboBox_LoaiHoaQua.Location = new System.Drawing.Point(96, 29);
            this.comboBox_LoaiHoaQua.Name = "comboBox_LoaiHoaQua";
            this.comboBox_LoaiHoaQua.Size = new System.Drawing.Size(148, 21);
            this.comboBox_LoaiHoaQua.TabIndex = 0;
            this.comboBox_LoaiHoaQua.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoaiHoaQua_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại hoa quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.Enabled = false;
            this.textBox_DonGia.Location = new System.Drawing.Point(311, 29);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(100, 20);
            this.textBox_DonGia.TabIndex = 4;
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(481, 29);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown_SoLuong.TabIndex = 5;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Location = new System.Drawing.Point(186, 83);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(98, 33);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Location = new System.Drawing.Point(290, 83);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(98, 33);
            this.button_Xoa.TabIndex = 7;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chi tiết đơn hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(24, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(550, 212);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền phải trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số tiền khách đưa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số tiền trả lại";
            // 
            // textBox_TongTienPhaiTra
            // 
            this.textBox_TongTienPhaiTra.Enabled = false;
            this.textBox_TongTienPhaiTra.Location = new System.Drawing.Point(429, 382);
            this.textBox_TongTienPhaiTra.Name = "textBox_TongTienPhaiTra";
            this.textBox_TongTienPhaiTra.Size = new System.Drawing.Size(145, 20);
            this.textBox_TongTienPhaiTra.TabIndex = 13;
            // 
            // textBox_SoTienTraLai
            // 
            this.textBox_SoTienTraLai.Enabled = false;
            this.textBox_SoTienTraLai.Location = new System.Drawing.Point(429, 442);
            this.textBox_SoTienTraLai.Name = "textBox_SoTienTraLai";
            this.textBox_SoTienTraLai.Size = new System.Drawing.Size(145, 20);
            this.textBox_SoTienTraLai.TabIndex = 14;
            // 
            // textBox_SoTienKhachDua
            // 
            this.textBox_SoTienKhachDua.Location = new System.Drawing.Point(429, 412);
            this.textBox_SoTienKhachDua.Name = "textBox_SoTienKhachDua";
            this.textBox_SoTienKhachDua.Size = new System.Drawing.Size(145, 20);
            this.textBox_SoTienKhachDua.TabIndex = 15;
            this.textBox_SoTienKhachDua.TextChanged += new System.EventHandler(this.textBox_SoTienKhachDua_TextChanged);
            // 
            // button_HoanThanh
            // 
            this.button_HoanThanh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HoanThanh.Location = new System.Drawing.Point(476, 468);
            this.button_HoanThanh.Name = "button_HoanThanh";
            this.button_HoanThanh.Size = new System.Drawing.Size(98, 33);
            this.button_HoanThanh.TabIndex = 16;
            this.button_HoanThanh.Text = "Hoàn thành";
            this.button_HoanThanh.UseVisualStyleBackColor = false;
            this.button_HoanThanh.Click += new System.EventHandler(this.button_HoanThanh_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(586, 513);
            this.Controls.Add(this.button_HoanThanh);
            this.Controls.Add(this.textBox_SoTienKhachDua);
            this.Controls.Add(this.textBox_SoTienTraLai);
            this.Controls.Add(this.textBox_TongTienPhaiTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.numericUpDown_SoLuong);
            this.Controls.Add(this.textBox_DonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_LoaiHoaQua);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_LoaiHoaQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_TongTienPhaiTra;
        private System.Windows.Forms.TextBox textBox_SoTienTraLai;
        private System.Windows.Forms.TextBox textBox_SoTienKhachDua;
        private System.Windows.Forms.Button button_HoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

