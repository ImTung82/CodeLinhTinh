namespace QuanLyQuanCafe
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
            this.comboBox_Ban = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_ChinhSua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_GhiChu = new System.Windows.Forms.RichTextBox();
            this.comboBox_DoUong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.button_HoanThanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Ban
            // 
            this.comboBox_Ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_Ban.FormattingEnabled = true;
            this.comboBox_Ban.Items.AddRange(new object[] {
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
            this.comboBox_Ban.Location = new System.Drawing.Point(1, 0);
            this.comboBox_Ban.Name = "comboBox_Ban";
            this.comboBox_Ban.Size = new System.Drawing.Size(162, 423);
            this.comboBox_Ban.TabIndex = 0;
            this.comboBox_Ban.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ban_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_ChinhSua);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Gia);
            this.groupBox1.Controls.Add(this.numericUpDown_SoLuong);
            this.groupBox1.Controls.Add(this.richTextBox_GhiChu);
            this.groupBox1.Controls.Add(this.comboBox_DoUong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(169, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Location = new System.Drawing.Point(576, 176);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 10;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ChinhSua
            // 
            this.button_ChinhSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSua.Location = new System.Drawing.Point(487, 176);
            this.button_ChinhSua.Name = "button_ChinhSua";
            this.button_ChinhSua.Size = new System.Drawing.Size(75, 23);
            this.button_ChinhSua.TabIndex = 9;
            this.button_ChinhSua.Text = "Chỉnh sửa";
            this.button_ChinhSua.UseVisualStyleBackColor = false;
            this.button_ChinhSua.Click += new System.EventHandler(this.button_ChinhSua_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Location = new System.Drawing.Point(398, 176);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Enabled = false;
            this.textBox_Gia.Location = new System.Drawing.Point(485, 65);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(166, 20);
            this.textBox_Gia.TabIndex = 5;
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(485, 25);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown_SoLuong.TabIndex = 4;
            // 
            // richTextBox_GhiChu
            // 
            this.richTextBox_GhiChu.Location = new System.Drawing.Point(70, 65);
            this.richTextBox_GhiChu.Name = "richTextBox_GhiChu";
            this.richTextBox_GhiChu.Size = new System.Drawing.Size(299, 134);
            this.richTextBox_GhiChu.TabIndex = 3;
            this.richTextBox_GhiChu.Text = "";
            // 
            // comboBox_DoUong
            // 
            this.comboBox_DoUong.FormattingEnabled = true;
            this.comboBox_DoUong.Location = new System.Drawing.Point(69, 25);
            this.comboBox_DoUong.Name = "comboBox_DoUong";
            this.comboBox_DoUong.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DoUong.TabIndex = 2;
            this.comboBox_DoUong.SelectedIndexChanged += new System.EventHandler(this.comboBox_DoUong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đồ uống";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thành tiền";
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Enabled = false;
            this.textBox_ThanhTien.Location = new System.Drawing.Point(554, 435);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(166, 20);
            this.textBox_ThanhTien.TabIndex = 6;
            // 
            // button_HoanThanh
            // 
            this.button_HoanThanh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HoanThanh.Location = new System.Drawing.Point(726, 433);
            this.button_HoanThanh.Name = "button_HoanThanh";
            this.button_HoanThanh.Size = new System.Drawing.Size(94, 23);
            this.button_HoanThanh.TabIndex = 9;
            this.button_HoanThanh.Text = "Hoàn thành";
            this.button_HoanThanh.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 478);
            this.Controls.Add(this.button_HoanThanh);
            this.Controls.Add(this.textBox_ThanhTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Ban);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Ban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.RichTextBox richTextBox_GhiChu;
        private System.Windows.Forms.ComboBox comboBox_DoUong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_ChinhSua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Button button_HoanThanh;
    }
}

