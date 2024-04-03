namespace QuanLyCuaHangTruyenTranh
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_ListQuanLy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TenKhach = new System.Windows.Forms.TextBox();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.comboBox_TenTruyen = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.button_MuonTruyen = new System.Windows.Forms.Button();
            this.button_TraTruyen = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::QuanLyCuaHangTruyenTranh.Properties.Resources._2024_03_13_21_54_37;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // dataGridView_ListQuanLy
            // 
            this.dataGridView_ListQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListQuanLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListQuanLy.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_ListQuanLy.Location = new System.Drawing.Point(12, 315);
            this.dataGridView_ListQuanLy.Name = "dataGridView_ListQuanLy";
            this.dataGridView_ListQuanLy.ReadOnly = true;
            this.dataGridView_ListQuanLy.Size = new System.Drawing.Size(925, 289);
            this.dataGridView_ListQuanLy.TabIndex = 1;
            this.dataGridView_ListQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListQuanLy_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(464, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(464, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(464, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên truyện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(464, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn giá / ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(464, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ContextMenuStrip = this.contextMenuStrip1;
            this.label6.Location = new System.Drawing.Point(464, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày trả";
            // 
            // textBox_TenKhach
            // 
            this.textBox_TenKhach.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_TenKhach.Location = new System.Drawing.Point(577, 23);
            this.textBox_TenKhach.Name = "textBox_TenKhach";
            this.textBox_TenKhach.Size = new System.Drawing.Size(351, 20);
            this.textBox_TenKhach.TabIndex = 8;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_DonGia.Enabled = false;
            this.textBox_DonGia.Location = new System.Drawing.Point(577, 156);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(351, 20);
            this.textBox_DonGia.TabIndex = 9;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_SDT.Location = new System.Drawing.Point(577, 67);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(351, 20);
            this.textBox_SDT.TabIndex = 10;
            this.textBox_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SDT_KeyPress);
            this.textBox_SDT.Leave += new System.EventHandler(this.textBox_SDT_Leave);
            // 
            // comboBox_TenTruyen
            // 
            this.comboBox_TenTruyen.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBox_TenTruyen.FormattingEnabled = true;
            this.comboBox_TenTruyen.Location = new System.Drawing.Point(577, 111);
            this.comboBox_TenTruyen.Name = "comboBox_TenTruyen";
            this.comboBox_TenTruyen.Size = new System.Drawing.Size(351, 21);
            this.comboBox_TenTruyen.TabIndex = 11;
            this.comboBox_TenTruyen.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenTruyen_SelectedIndexChanged);
            // 
            // dateTimePicker_NgayMuon
            // 
            this.dateTimePicker_NgayMuon.ContextMenuStrip = this.contextMenuStrip1;
            this.dateTimePicker_NgayMuon.CustomFormat = "";
            this.dateTimePicker_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayMuon.Location = new System.Drawing.Point(577, 196);
            this.dateTimePicker_NgayMuon.Name = "dateTimePicker_NgayMuon";
            this.dateTimePicker_NgayMuon.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker_NgayMuon.TabIndex = 12;
            // 
            // dateTimePicker_NgayTra
            // 
            this.dateTimePicker_NgayTra.ContextMenuStrip = this.contextMenuStrip1;
            this.dateTimePicker_NgayTra.Enabled = false;
            this.dateTimePicker_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayTra.Location = new System.Drawing.Point(577, 242);
            this.dateTimePicker_NgayTra.Name = "dateTimePicker_NgayTra";
            this.dateTimePicker_NgayTra.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker_NgayTra.TabIndex = 13;
            // 
            // button_MuonTruyen
            // 
            this.button_MuonTruyen.ContextMenuStrip = this.contextMenuStrip1;
            this.button_MuonTruyen.Location = new System.Drawing.Point(805, 192);
            this.button_MuonTruyen.Name = "button_MuonTruyen";
            this.button_MuonTruyen.Size = new System.Drawing.Size(110, 32);
            this.button_MuonTruyen.TabIndex = 14;
            this.button_MuonTruyen.Text = "Mượn Truyện";
            this.button_MuonTruyen.UseVisualStyleBackColor = true;
            this.button_MuonTruyen.Click += new System.EventHandler(this.button_MuonTruyen_Click);
            // 
            // button_TraTruyen
            // 
            this.button_TraTruyen.ContextMenuStrip = this.contextMenuStrip1;
            this.button_TraTruyen.Location = new System.Drawing.Point(805, 230);
            this.button_TraTruyen.Name = "button_TraTruyen";
            this.button_TraTruyen.Size = new System.Drawing.Size(110, 32);
            this.button_TraTruyen.TabIndex = 15;
            this.button_TraTruyen.Text = "Trả Truyện";
            this.button_TraTruyen.UseVisualStyleBackColor = true;
            this.button_TraTruyen.Click += new System.EventHandler(this.button_TraTruyen_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.ContextMenuStrip = this.contextMenuStrip1;
            this.button_Xoa.Location = new System.Drawing.Point(805, 268);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(110, 32);
            this.button_Xoa.TabIndex = 16;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 616);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_TraTruyen);
            this.Controls.Add(this.button_MuonTruyen);
            this.Controls.Add(this.dateTimePicker_NgayTra);
            this.Controls.Add(this.dateTimePicker_NgayMuon);
            this.Controls.Add(this.comboBox_TenTruyen);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.textBox_DonGia);
            this.Controls.Add(this.textBox_TenKhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ListQuanLy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý cửa hàng truyện tranh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListQuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_ListQuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_TenKhach;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.ComboBox comboBox_TenTruyen;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayMuon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayTra;
        private System.Windows.Forms.Button button_MuonTruyen;
        private System.Windows.Forms.Button button_TraTruyen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.Button button_Xoa;
    }
}

