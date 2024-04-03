namespace De4_QuanLyDiemThi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.comboBox_MaSV = new System.Windows.Forms.ComboBox();
            this.textBox_HoTenSV = new System.Windows.Forms.TextBox();
            this.textBox_DiemToan = new System.Windows.Forms.TextBox();
            this.textBox_DiemVan = new System.Windows.Forms.TextBox();
            this.textBox_DiemNN = new System.Windows.Forms.TextBox();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.dataGridView_ThongKe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_ThongKe = new System.Windows.Forms.ComboBox();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_List);
            this.tabPage1.Controls.Add(this.textBox_DiemNN);
            this.tabPage1.Controls.Add(this.textBox_DiemVan);
            this.tabPage1.Controls.Add(this.textBox_DiemToan);
            this.tabPage1.Controls.Add(this.textBox_HoTenSV);
            this.tabPage1.Controls.Add(this.comboBox_MaSV);
            this.tabPage1.Controls.Add(this.button_Xoa);
            this.tabPage1.Controls.Add(this.button_Sua);
            this.tabPage1.Controls.Add(this.button_Them);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_ThongKe);
            this.tabPage2.Controls.Add(this.comboBox_ThongKe);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView_ThongKe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm văn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm ngoại ngữ:";
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Them.Location = new System.Drawing.Point(220, 92);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(93, 43);
            this.button_Them.TabIndex = 5;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Sua.Location = new System.Drawing.Point(336, 92);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(93, 43);
            this.button_Sua.TabIndex = 6;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Xoa.Location = new System.Drawing.Point(452, 92);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(93, 43);
            this.button_Xoa.TabIndex = 7;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // comboBox_MaSV
            // 
            this.comboBox_MaSV.FormattingEnabled = true;
            this.comboBox_MaSV.Location = new System.Drawing.Point(70, 9);
            this.comboBox_MaSV.Name = "comboBox_MaSV";
            this.comboBox_MaSV.Size = new System.Drawing.Size(242, 21);
            this.comboBox_MaSV.TabIndex = 1;
            this.comboBox_MaSV.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaSV_SelectedIndexChanged);
            // 
            // textBox_HoTenSV
            // 
            this.textBox_HoTenSV.Location = new System.Drawing.Point(429, 12);
            this.textBox_HoTenSV.Name = "textBox_HoTenSV";
            this.textBox_HoTenSV.Size = new System.Drawing.Size(355, 20);
            this.textBox_HoTenSV.TabIndex = 9;
            // 
            // textBox_DiemToan
            // 
            this.textBox_DiemToan.Location = new System.Drawing.Point(90, 52);
            this.textBox_DiemToan.Name = "textBox_DiemToan";
            this.textBox_DiemToan.Size = new System.Drawing.Size(143, 20);
            this.textBox_DiemToan.TabIndex = 2;
            this.textBox_DiemToan.Leave += new System.EventHandler(this.textBox_DiemToan_Leave);
            // 
            // textBox_DiemVan
            // 
            this.textBox_DiemVan.Location = new System.Drawing.Point(336, 51);
            this.textBox_DiemVan.Name = "textBox_DiemVan";
            this.textBox_DiemVan.Size = new System.Drawing.Size(134, 20);
            this.textBox_DiemVan.TabIndex = 3;
            this.textBox_DiemVan.TextChanged += new System.EventHandler(this.textBox_DiemVan_TextChanged);
            // 
            // textBox_DiemNN
            // 
            this.textBox_DiemNN.Location = new System.Drawing.Point(614, 51);
            this.textBox_DiemNN.Name = "textBox_DiemNN";
            this.textBox_DiemNN.Size = new System.Drawing.Size(170, 20);
            this.textBox_DiemNN.TabIndex = 4;
            this.textBox_DiemNN.TextChanged += new System.EventHandler(this.textBox_DiemNN_TextChanged);
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Location = new System.Drawing.Point(0, 139);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.Size = new System.Drawing.Size(791, 287);
            this.dataGridView_List.TabIndex = 13;
            this.dataGridView_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellClick);
            // 
            // dataGridView_ThongKe
            // 
            this.dataGridView_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ThongKe.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThongKe.Location = new System.Drawing.Point(0, 66);
            this.dataGridView_ThongKe.Name = "dataGridView_ThongKe";
            this.dataGridView_ThongKe.Size = new System.Drawing.Size(791, 360);
            this.dataGridView_ThongKe.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phân loại sinh viên";
            // 
            // comboBox_ThongKe
            // 
            this.comboBox_ThongKe.FormattingEnabled = true;
            this.comboBox_ThongKe.Items.AddRange(new object[] {
            "Sinh viên đạt loại Giỏi",
            "Sinh viên đạt loại Khá",
            "Sinh viên đạt loại TB"});
            this.comboBox_ThongKe.Location = new System.Drawing.Point(165, 24);
            this.comboBox_ThongKe.Name = "comboBox_ThongKe";
            this.comboBox_ThongKe.Size = new System.Drawing.Size(381, 21);
            this.comboBox_ThongKe.TabIndex = 16;
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.Location = new System.Drawing.Point(626, 15);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(105, 36);
            this.button_ThongKe.TabIndex = 17;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.UseVisualStyleBackColor = true;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_DiemNN;
        private System.Windows.Forms.TextBox textBox_DiemVan;
        private System.Windows.Forms.TextBox textBox_DiemToan;
        private System.Windows.Forms.TextBox textBox_HoTenSV;
        private System.Windows.Forms.ComboBox comboBox_MaSV;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.ComboBox comboBox_ThongKe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_ThongKe;
    }
}

