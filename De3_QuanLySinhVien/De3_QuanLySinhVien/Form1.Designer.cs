namespace De3_QuanLySinhVien
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
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Loc = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.textBox_MaSV = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox_NoiSinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.AllowUserToDeleteRows = false;
            this.dgv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_List.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Location = new System.Drawing.Point(1, 127);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.Size = new System.Drawing.Size(798, 322);
            this.dgv_List.TabIndex = 0;
            this.dgv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_List_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(533, 49);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Nam.TabIndex = 5;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(604, 49);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_Nu.TabIndex = 6;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(470, 80);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 31);
            this.button_Them.TabIndex = 7;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Loc
            // 
            this.button_Loc.Location = new System.Drawing.Point(713, 80);
            this.button_Loc.Name = "button_Loc";
            this.button_Loc.Size = new System.Drawing.Size(75, 31);
            this.button_Loc.TabIndex = 10;
            this.button_Loc.Text = "Lọc";
            this.button_Loc.UseVisualStyleBackColor = true;
            this.button_Loc.Click += new System.EventHandler(this.button_Loc_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(632, 80);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 31);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(551, 80);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 31);
            this.button_Sua.TabIndex = 8;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // textBox_MaSV
            // 
            this.textBox_MaSV.Location = new System.Drawing.Point(80, 10);
            this.textBox_MaSV.Name = "textBox_MaSV";
            this.textBox_MaSV.Size = new System.Drawing.Size(332, 20);
            this.textBox_MaSV.TabIndex = 1;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(80, 48);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(332, 20);
            this.textBox_HoTen.TabIndex = 2;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(80, 83);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 3;
            this.dateTimePicker_NgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_NoiSinh
            // 
            this.comboBox_NoiSinh.FormattingEnabled = true;
            this.comboBox_NoiSinh.Items.AddRange(new object[] {
            "Hà Nội",
            "Hải Phòng",
            "Đà Nẵng",
            "Huế",
            "TP. Hồ Chí Minh",
            "Bình Dương",
            "Thanh Hóa"});
            this.comboBox_NoiSinh.Location = new System.Drawing.Point(524, 9);
            this.comboBox_NoiSinh.Name = "comboBox_NoiSinh";
            this.comboBox_NoiSinh.Size = new System.Drawing.Size(263, 21);
            this.comboBox_NoiSinh.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_NoiSinh);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.textBox_HoTen);
            this.Controls.Add(this.textBox_MaSV);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Loc);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_List);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên (Chu Xuân Tùng - 2251172551)";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Loc;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.TextBox textBox_MaSV;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.ComboBox comboBox_NoiSinh;
    }
}

