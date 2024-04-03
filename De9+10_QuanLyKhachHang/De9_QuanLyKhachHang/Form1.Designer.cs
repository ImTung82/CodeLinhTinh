namespace De9_QuanLyKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.textBox_SoPhongThue = new System.Windows.Forms.TextBox();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.comboBox_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TKTen = new System.Windows.Forms.TextBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 273);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GIới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số phòng thuê";
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Location = new System.Drawing.Point(129, 15);
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(202, 20);
            this.textBox_TenKH.TabIndex = 1;
            // 
            // textBox_SoPhongThue
            // 
            this.textBox_SoPhongThue.Location = new System.Drawing.Point(129, 129);
            this.textBox_SoPhongThue.Name = "textBox_SoPhongThue";
            this.textBox_SoPhongThue.Size = new System.Drawing.Size(191, 20);
            this.textBox_SoPhongThue.TabIndex = 5;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(129, 54);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nam.TabIndex = 2;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(243, 54);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_Nu.TabIndex = 3;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // comboBox_LoaiPhong
            // 
            this.comboBox_LoaiPhong.FormattingEnabled = true;
            this.comboBox_LoaiPhong.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi"});
            this.comboBox_LoaiPhong.Location = new System.Drawing.Point(129, 91);
            this.comboBox_LoaiPhong.Name = "comboBox_LoaiPhong";
            this.comboBox_LoaiPhong.Size = new System.Drawing.Size(86, 21);
            this.comboBox_LoaiPhong.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên";
            // 
            // textBox_TKTen
            // 
            this.textBox_TKTen.Location = new System.Drawing.Point(507, 18);
            this.textBox_TKTen.Name = "textBox_TKTen";
            this.textBox_TKTen.Size = new System.Drawing.Size(222, 20);
            this.textBox_TKTen.TabIndex = 6;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.Location = new System.Drawing.Point(450, 56);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.button_TimKiem.TabIndex = 7;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Location = new System.Drawing.Point(450, 127);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Location = new System.Drawing.Point(552, 127);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Location = new System.Drawing.Point(654, 126);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 10;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.textBox_TKTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_LoaiPhong);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.textBox_SoPhongThue);
            this.Controls.Add(this.textBox_TenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.TextBox textBox_SoPhongThue;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.ComboBox comboBox_LoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TKTen;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
    }
}

