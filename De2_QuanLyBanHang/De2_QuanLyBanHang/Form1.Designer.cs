namespace De2_QuanLyBanHang
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
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_TaoDonHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TenKhach = new System.Windows.Forms.TextBox();
            this.comboBox_DonHang = new System.Windows.Forms.ComboBox();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.button_Nhap = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_List.Location = new System.Drawing.Point(341, 0);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.Size = new System.Drawing.Size(459, 451);
            this.dataGridView_List.TabIndex = 0;
            this.dataGridView_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellClick);
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
            // button_TaoDonHang
            // 
            this.button_TaoDonHang.ContextMenuStrip = this.contextMenuStrip1;
            this.button_TaoDonHang.Location = new System.Drawing.Point(113, 12);
            this.button_TaoDonHang.Name = "button_TaoDonHang";
            this.button_TaoDonHang.Size = new System.Drawing.Size(127, 41);
            this.button_TaoDonHang.TabIndex = 1;
            this.button_TaoDonHang.Text = "Tạo đơn hàng";
            this.button_TaoDonHang.UseVisualStyleBackColor = true;
            this.button_TaoDonHang.Click += new System.EventHandler(this.button_TaoDonHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(19, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            // 
            // textBox_TenKhach
            // 
            this.textBox_TenKhach.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_TenKhach.Location = new System.Drawing.Point(113, 74);
            this.textBox_TenKhach.Name = "textBox_TenKhach";
            this.textBox_TenKhach.Size = new System.Drawing.Size(137, 20);
            this.textBox_TenKhach.TabIndex = 7;
            // 
            // comboBox_DonHang
            // 
            this.comboBox_DonHang.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBox_DonHang.FormattingEnabled = true;
            this.comboBox_DonHang.Location = new System.Drawing.Point(112, 121);
            this.comboBox_DonHang.Name = "comboBox_DonHang";
            this.comboBox_DonHang.Size = new System.Drawing.Size(138, 21);
            this.comboBox_DonHang.TabIndex = 8;
            this.comboBox_DonHang.SelectedIndexChanged += new System.EventHandler(this.comboBox_DonHang_SelectedIndexChanged);
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.ContextMenuStrip = this.contextMenuStrip1;
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(112, 168);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown_SoLuong.TabIndex = 9;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_DonGia.Enabled = false;
            this.textBox_DonGia.Location = new System.Drawing.Point(112, 209);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(138, 20);
            this.textBox_DonGia.TabIndex = 10;
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_TongTien.Enabled = false;
            this.textBox_TongTien.Location = new System.Drawing.Point(112, 400);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(100, 20);
            this.textBox_TongTien.TabIndex = 11;
            // 
            // button_Nhap
            // 
            this.button_Nhap.ContextMenuStrip = this.contextMenuStrip1;
            this.button_Nhap.Location = new System.Drawing.Point(281, 109);
            this.button_Nhap.Name = "button_Nhap";
            this.button_Nhap.Size = new System.Drawing.Size(39, 42);
            this.button_Nhap.TabIndex = 12;
            this.button_Nhap.Text = ">>";
            this.button_Nhap.UseVisualStyleBackColor = true;
            this.button_Nhap.Click += new System.EventHandler(this.button_Nhap_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.ContextMenuStrip = this.contextMenuStrip1;
            this.button_Xoa.Location = new System.Drawing.Point(281, 157);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(39, 42);
            this.button_Xoa.TabIndex = 13;
            this.button_Xoa.Text = "<<";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.ContextMenuStrip = this.contextMenuStrip1;
            this.button_ThanhToan.Location = new System.Drawing.Point(113, 296);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(127, 41);
            this.button_ThanhToan.TabIndex = 14;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.UseVisualStyleBackColor = true;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button_ThanhToan);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Nhap);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.textBox_DonGia);
            this.Controls.Add(this.numericUpDown_SoLuong);
            this.Controls.Add(this.comboBox_DonHang);
            this.Controls.Add(this.textBox_TenKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TaoDonHang);
            this.Controls.Add(this.dataGridView_List);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.Button button_TaoDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TenKhach;
        private System.Windows.Forms.ComboBox comboBox_DonHang;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Button button_Nhap;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
    }
}

