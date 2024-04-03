namespace DinhDangChu
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
            this.textBox1_NhapTen = new System.Windows.Forms.TextBox();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.radioButton_Red = new System.Windows.Forms.RadioButton();
            this.radioButton_Green = new System.Windows.Forms.RadioButton();
            this.radioButton_Blue = new System.Windows.Forms.RadioButton();
            this.radioButton_Black = new System.Windows.Forms.RadioButton();
            this.groupBox_Font = new System.Windows.Forms.GroupBox();
            this.checkBox_Bold = new System.Windows.Forms.CheckBox();
            this.checkBox_Italic = new System.Windows.Forms.CheckBox();
            this.checkBox_Underline = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.groupBox_Color.SuspendLayout();
            this.groupBox_Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1_NhapTen
            // 
            this.textBox1_NhapTen.Location = new System.Drawing.Point(105, 22);
            this.textBox1_NhapTen.Name = "textBox1_NhapTen";
            this.textBox1_NhapTen.Size = new System.Drawing.Size(196, 20);
            this.textBox1_NhapTen.TabIndex = 1;
            this.textBox1_NhapTen.TextChanged += new System.EventHandler(this.textBox1_NhapTen_TextChanged);
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.radioButton_Black);
            this.groupBox_Color.Controls.Add(this.radioButton_Blue);
            this.groupBox_Color.Controls.Add(this.radioButton_Green);
            this.groupBox_Color.Controls.Add(this.radioButton_Red);
            this.groupBox_Color.Location = new System.Drawing.Point(26, 80);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(153, 172);
            this.groupBox_Color.TabIndex = 2;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Color";
            // 
            // radioButton_Red
            // 
            this.radioButton_Red.AutoSize = true;
            this.radioButton_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Red.ForeColor = System.Drawing.Color.Red;
            this.radioButton_Red.Location = new System.Drawing.Point(7, 19);
            this.radioButton_Red.Name = "radioButton_Red";
            this.radioButton_Red.Size = new System.Drawing.Size(56, 22);
            this.radioButton_Red.TabIndex = 0;
            this.radioButton_Red.TabStop = true;
            this.radioButton_Red.Text = "Red";
            this.radioButton_Red.UseVisualStyleBackColor = true;
            this.radioButton_Red.CheckedChanged += new System.EventHandler(this.radioButton_Red_CheckedChanged);
            // 
            // radioButton_Green
            // 
            this.radioButton_Green.AutoSize = true;
            this.radioButton_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton_Green.Location = new System.Drawing.Point(7, 60);
            this.radioButton_Green.Name = "radioButton_Green";
            this.radioButton_Green.Size = new System.Drawing.Size(72, 22);
            this.radioButton_Green.TabIndex = 1;
            this.radioButton_Green.TabStop = true;
            this.radioButton_Green.Text = "Green";
            this.radioButton_Green.UseVisualStyleBackColor = true;
            this.radioButton_Green.CheckedChanged += new System.EventHandler(this.radioButton_Green_CheckedChanged);
            // 
            // radioButton_Blue
            // 
            this.radioButton_Blue.AutoSize = true;
            this.radioButton_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Blue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton_Blue.Location = new System.Drawing.Point(7, 98);
            this.radioButton_Blue.Name = "radioButton_Blue";
            this.radioButton_Blue.Size = new System.Drawing.Size(59, 22);
            this.radioButton_Blue.TabIndex = 2;
            this.radioButton_Blue.TabStop = true;
            this.radioButton_Blue.Text = "Blue";
            this.radioButton_Blue.UseVisualStyleBackColor = true;
            this.radioButton_Blue.CheckedChanged += new System.EventHandler(this.radioButton_Blue_CheckedChanged);
            // 
            // radioButton_Black
            // 
            this.radioButton_Black.AutoSize = true;
            this.radioButton_Black.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Black.Location = new System.Drawing.Point(7, 136);
            this.radioButton_Black.Name = "radioButton_Black";
            this.radioButton_Black.Size = new System.Drawing.Size(68, 22);
            this.radioButton_Black.TabIndex = 3;
            this.radioButton_Black.TabStop = true;
            this.radioButton_Black.Text = "Black";
            this.radioButton_Black.UseVisualStyleBackColor = true;
            this.radioButton_Black.CheckedChanged += new System.EventHandler(this.radioButton_Black_CheckedChanged);
            // 
            // groupBox_Font
            // 
            this.groupBox_Font.Controls.Add(this.checkBox_Underline);
            this.groupBox_Font.Controls.Add(this.checkBox_Italic);
            this.groupBox_Font.Controls.Add(this.checkBox_Bold);
            this.groupBox_Font.Location = new System.Drawing.Point(224, 80);
            this.groupBox_Font.Name = "groupBox_Font";
            this.groupBox_Font.Size = new System.Drawing.Size(131, 172);
            this.groupBox_Font.TabIndex = 3;
            this.groupBox_Font.TabStop = false;
            this.groupBox_Font.Text = "Font";
            // 
            // checkBox_Bold
            // 
            this.checkBox_Bold.AutoSize = true;
            this.checkBox_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Bold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBox_Bold.Location = new System.Drawing.Point(7, 23);
            this.checkBox_Bold.Name = "checkBox_Bold";
            this.checkBox_Bold.Size = new System.Drawing.Size(101, 22);
            this.checkBox_Bold.TabIndex = 0;
            this.checkBox_Bold.Text = "Đậm Bold";
            this.checkBox_Bold.UseVisualStyleBackColor = true;
            this.checkBox_Bold.CheckedChanged += new System.EventHandler(this.checkBox_Bold_CheckedChanged);
            // 
            // checkBox_Italic
            // 
            this.checkBox_Italic.AutoSize = true;
            this.checkBox_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Italic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBox_Italic.Location = new System.Drawing.Point(7, 64);
            this.checkBox_Italic.Name = "checkBox_Italic";
            this.checkBox_Italic.Size = new System.Drawing.Size(119, 22);
            this.checkBox_Italic.TabIndex = 1;
            this.checkBox_Italic.Text = "Nghiên Italic";
            this.checkBox_Italic.UseVisualStyleBackColor = true;
            this.checkBox_Italic.CheckedChanged += new System.EventHandler(this.checkBox_Italic_CheckedChanged);
            // 
            // checkBox_Underline
            // 
            this.checkBox_Underline.AutoSize = true;
            this.checkBox_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Underline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkBox_Underline.Location = new System.Drawing.Point(7, 103);
            this.checkBox_Underline.Name = "checkBox_Underline";
            this.checkBox_Underline.Size = new System.Drawing.Size(108, 22);
            this.checkBox_Underline.TabIndex = 2;
            this.checkBox_Underline.Text = "Gạch chân";
            this.checkBox_Underline.UseVisualStyleBackColor = true;
            this.checkBox_Underline.CheckedChanged += new System.EventHandler(this.checkBox_Underline_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_Result.Location = new System.Drawing.Point(171, 357);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(161, 20);
            this.textBox_Result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_Font);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.textBox1_NhapTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định Dạng (Formater)";
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            this.groupBox_Font.ResumeLayout(false);
            this.groupBox_Font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_NhapTen;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.RadioButton radioButton_Black;
        private System.Windows.Forms.RadioButton radioButton_Blue;
        private System.Windows.Forms.RadioButton radioButton_Green;
        private System.Windows.Forms.RadioButton radioButton_Red;
        private System.Windows.Forms.GroupBox groupBox_Font;
        private System.Windows.Forms.CheckBox checkBox_Underline;
        private System.Windows.Forms.CheckBox checkBox_Italic;
        private System.Windows.Forms.CheckBox checkBox_Bold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

