namespace _2dgv_QuanLyBanHang
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_TheLoai = new System.Windows.Forms.ComboBox();
            this.dataGridView_LoaiHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LoaiHang = new System.Windows.Forms.Label();
            this.button_TaoDon = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenKhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_DonHang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            // 
            // comboBox_TheLoai
            // 
            this.comboBox_TheLoai.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBox_TheLoai.FormattingEnabled = true;
            this.comboBox_TheLoai.Location = new System.Drawing.Point(61, 10);
            this.comboBox_TheLoai.Name = "comboBox_TheLoai";
            this.comboBox_TheLoai.Size = new System.Drawing.Size(237, 21);
            this.comboBox_TheLoai.TabIndex = 1;
            this.comboBox_TheLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox_TheLoai_SelectedIndexChanged);
            // 
            // dataGridView_LoaiHang
            // 
            this.dataGridView_LoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiHang.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_LoaiHang.Location = new System.Drawing.Point(16, 81);
            this.dataGridView_LoaiHang.Name = "dataGridView_LoaiHang";
            this.dataGridView_LoaiHang.ReadOnly = true;
            this.dataGridView_LoaiHang.Size = new System.Drawing.Size(282, 357);
            this.dataGridView_LoaiHang.TabIndex = 2;
            this.dataGridView_LoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LoaiHang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Các hàng thuộc loại:";
            // 
            // label_LoaiHang
            // 
            this.label_LoaiHang.AutoSize = true;
            this.label_LoaiHang.ContextMenuStrip = this.contextMenuStrip1;
            this.label_LoaiHang.Location = new System.Drawing.Point(115, 47);
            this.label_LoaiHang.Name = "label_LoaiHang";
            this.label_LoaiHang.Size = new System.Drawing.Size(16, 13);
            this.label_LoaiHang.TabIndex = 4;
            this.label_LoaiHang.Text = "...";
            // 
            // button_TaoDon
            // 
            this.button_TaoDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_TaoDon.ContextMenuStrip = this.contextMenuStrip1;
            this.button_TaoDon.Location = new System.Drawing.Point(338, 7);
            this.button_TaoDon.Name = "button_TaoDon";
            this.button_TaoDon.Size = new System.Drawing.Size(87, 41);
            this.button_TaoDon.TabIndex = 5;
            this.button_TaoDon.Text = "Tạo đơn";
            this.button_TaoDon.UseVisualStyleBackColor = false;
            this.button_TaoDon.Click += new System.EventHandler(this.button_TaoDon_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.ContextMenuStrip = this.contextMenuStrip1;
            this.button_Them.Location = new System.Drawing.Point(396, 107);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(29, 25);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = ">>";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.ContextMenuStrip = this.contextMenuStrip1;
            this.button_Xoa.Location = new System.Drawing.Point(336, 138);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(89, 29);
            this.button_Xoa.TabIndex = 7;
            this.button_Xoa.Text = "<<";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.ContextMenuStrip = this.contextMenuStrip1;
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(338, 110);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_SoLuong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(457, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên khách";
            // 
            // textBox_TenKhach
            // 
            this.textBox_TenKhach.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_TenKhach.Location = new System.Drawing.Point(519, 10);
            this.textBox_TenKhach.Name = "textBox_TenKhach";
            this.textBox_TenKhach.Size = new System.Drawing.Size(329, 20);
            this.textBox_TenKhach.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(457, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chi tiết đơn hàng";
            // 
            // dataGridView_DonHang
            // 
            this.dataGridView_DonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_DonHang.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_DonHang.Location = new System.Drawing.Point(460, 81);
            this.dataGridView_DonHang.Name = "dataGridView_DonHang";
            this.dataGridView_DonHang.ReadOnly = true;
            this.dataGridView_DonHang.Size = new System.Drawing.Size(388, 289);
            this.dataGridView_DonHang.TabIndex = 12;
            this.dataGridView_DonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DonHang_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ContextMenuStrip = this.contextMenuStrip1;
            this.label6.Location = new System.Drawing.Point(460, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền";
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_TongTien.Enabled = false;
            this.textBox_TongTien.Location = new System.Drawing.Point(519, 376);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(329, 20);
            this.textBox_TongTien.TabIndex = 14;
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ThanhToan.ContextMenuStrip = this.contextMenuStrip1;
            this.button_ThanhToan.Location = new System.Drawing.Point(773, 415);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(75, 23);
            this.button_ThanhToan.TabIndex = 15;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.UseVisualStyleBackColor = false;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
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
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button_ThanhToan);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_DonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_TenKhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_SoLuong);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_TaoDon);
            this.Controls.Add(this.label_LoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_LoaiHang);
            this.Controls.Add(this.comboBox_TheLoai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TheLoai;
        private System.Windows.Forms.DataGridView dataGridView_LoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_LoaiHang;
        private System.Windows.Forms.Button button_TaoDon;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TenKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_DonHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

