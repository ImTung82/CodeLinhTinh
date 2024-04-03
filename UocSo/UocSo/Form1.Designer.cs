namespace UocSo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NhapSo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_SoDaNhap = new System.Windows.Forms.ComboBox();
            this.listBox_UocSo = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_SoDaNhap);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_NhapSo);
            this.groupBox1.Location = new System.Drawing.Point(53, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_UocSo);
            this.groupBox2.Location = new System.Drawing.Point(513, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // textBox_NhapSo
            // 
            this.textBox_NhapSo.Location = new System.Drawing.Point(16, 37);
            this.textBox_NhapSo.Name = "textBox_NhapSo";
            this.textBox_NhapSo.Size = new System.Drawing.Size(110, 20);
            this.textBox_NhapSo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Cập nhất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_SoDaNhap
            // 
            this.comboBox_SoDaNhap.FormattingEnabled = true;
            this.comboBox_SoDaNhap.Location = new System.Drawing.Point(16, 96);
            this.comboBox_SoDaNhap.Name = "comboBox_SoDaNhap";
            this.comboBox_SoDaNhap.Size = new System.Drawing.Size(204, 21);
            this.comboBox_SoDaNhap.TabIndex = 2;
            this.comboBox_SoDaNhap.SelectedIndexChanged += new System.EventHandler(this.comboBox_SoDaNhap_SelectedIndexChanged);
            // 
            // listBox_UocSo
            // 
            this.listBox_UocSo.FormattingEnabled = true;
            this.listBox_UocSo.Location = new System.Drawing.Point(7, 20);
            this.listBox_UocSo.Name = "listBox_UocSo";
            this.listBox_UocSo.Size = new System.Drawing.Size(228, 121);
            this.listBox_UocSo.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Tổng các ước số";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Số lượng các ước số chẵn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "&Số lượng các ước số nguyên tố";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "&Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_SoDaNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_NhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_UocSo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

