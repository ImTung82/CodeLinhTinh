namespace De3_QuanLySinhVien
{
    partial class Form2
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
            this.dgv_List2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TKMaSV = new System.Windows.Forms.TextBox();
            this.radioButton_TKNam = new System.Windows.Forms.RadioButton();
            this.radioButton_TKNu = new System.Windows.Forms.RadioButton();
            this.button_TKMaSV = new System.Windows.Forms.Button();
            this.button_TKNoiSinh = new System.Windows.Forms.Button();
            this.button_TKGioiTinh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_List2
            // 
            this.dgv_List2.AllowUserToAddRows = false;
            this.dgv_List2.AllowUserToDeleteRows = false;
            this.dgv_List2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_List2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_List2.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv_List2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List2.Location = new System.Drawing.Point(1, 123);
            this.dgv_List2.Name = "dgv_List2";
            this.dgv_List2.Size = new System.Drawing.Size(798, 328);
            this.dgv_List2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nơi sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giới tính";
            // 
            // textBox_TKMaSV
            // 
            this.textBox_TKMaSV.Location = new System.Drawing.Point(72, 6);
            this.textBox_TKMaSV.Name = "textBox_TKMaSV";
            this.textBox_TKMaSV.Size = new System.Drawing.Size(329, 20);
            this.textBox_TKMaSV.TabIndex = 15;
            // 
            // radioButton_TKNam
            // 
            this.radioButton_TKNam.AutoSize = true;
            this.radioButton_TKNam.Location = new System.Drawing.Point(72, 83);
            this.radioButton_TKNam.Name = "radioButton_TKNam";
            this.radioButton_TKNam.Size = new System.Drawing.Size(47, 17);
            this.radioButton_TKNam.TabIndex = 17;
            this.radioButton_TKNam.TabStop = true;
            this.radioButton_TKNam.Text = "Nam";
            this.radioButton_TKNam.UseVisualStyleBackColor = true;
            // 
            // radioButton_TKNu
            // 
            this.radioButton_TKNu.AutoSize = true;
            this.radioButton_TKNu.Location = new System.Drawing.Point(147, 83);
            this.radioButton_TKNu.Name = "radioButton_TKNu";
            this.radioButton_TKNu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_TKNu.TabIndex = 18;
            this.radioButton_TKNu.TabStop = true;
            this.radioButton_TKNu.Text = "Nữ";
            this.radioButton_TKNu.UseVisualStyleBackColor = true;
            // 
            // button_TKMaSV
            // 
            this.button_TKMaSV.Location = new System.Drawing.Point(600, 9);
            this.button_TKMaSV.Name = "button_TKMaSV";
            this.button_TKMaSV.Size = new System.Drawing.Size(188, 32);
            this.button_TKMaSV.TabIndex = 19;
            this.button_TKMaSV.Text = "Tìm kiếm theo mã sinh viên";
            this.button_TKMaSV.UseVisualStyleBackColor = true;
            this.button_TKMaSV.Click += new System.EventHandler(this.button_TKMaSV_Click);
            // 
            // button_TKNoiSinh
            // 
            this.button_TKNoiSinh.Location = new System.Drawing.Point(600, 43);
            this.button_TKNoiSinh.Name = "button_TKNoiSinh";
            this.button_TKNoiSinh.Size = new System.Drawing.Size(188, 32);
            this.button_TKNoiSinh.TabIndex = 20;
            this.button_TKNoiSinh.Text = "Tìm kiếm theo nơi sinh";
            this.button_TKNoiSinh.UseVisualStyleBackColor = true;
            this.button_TKNoiSinh.Click += new System.EventHandler(this.button_TKNoiSinh_Click);
            // 
            // button_TKGioiTinh
            // 
            this.button_TKGioiTinh.Location = new System.Drawing.Point(600, 79);
            this.button_TKGioiTinh.Name = "button_TKGioiTinh";
            this.button_TKGioiTinh.Size = new System.Drawing.Size(188, 32);
            this.button_TKGioiTinh.TabIndex = 21;
            this.button_TKGioiTinh.Text = "Tìm kiếm theo giới tính";
            this.button_TKGioiTinh.UseVisualStyleBackColor = true;
            this.button_TKGioiTinh.Click += new System.EventHandler(this.button_TKGioiTinh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hà Nội",
            "Hải Phòng",
            "Đà Nẵng",
            "Huế",
            "TP. Hồ Chí Minh",
            "Bình Dương",
            "Thanh Hóa"});
            this.comboBox1.Location = new System.Drawing.Point(72, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_TKGioiTinh);
            this.Controls.Add(this.button_TKNoiSinh);
            this.Controls.Add(this.button_TKMaSV);
            this.Controls.Add(this.radioButton_TKNu);
            this.Controls.Add(this.radioButton_TKNam);
            this.Controls.Add(this.textBox_TKMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_List2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_List2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TKMaSV;
        private System.Windows.Forms.RadioButton radioButton_TKNam;
        private System.Windows.Forms.RadioButton radioButton_TKNu;
        private System.Windows.Forms.Button button_TKMaSV;
        private System.Windows.Forms.Button button_TKNoiSinh;
        private System.Windows.Forms.Button button_TKGioiTinh;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}