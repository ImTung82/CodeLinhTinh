namespace Program_AX_B_0
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NhapA = new System.Windows.Forms.TextBox();
            this.textBox_NhapB = new System.Windows.Forms.TextBox();
            this.textBox_Nghiem = new System.Windows.Forms.TextBox();
            this.button_Giai = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B = 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghiệm phương trình";
            // 
            // textBox_NhapA
            // 
            this.textBox_NhapA.Location = new System.Drawing.Point(239, 128);
            this.textBox_NhapA.Name = "textBox_NhapA";
            this.textBox_NhapA.Size = new System.Drawing.Size(453, 20);
            this.textBox_NhapA.TabIndex = 4;
            this.textBox_NhapA.TextChanged += new System.EventHandler(this.textBox_NhapA_TextChanged);
            this.textBox_NhapA.Leave += new System.EventHandler(this.textBox_NhapA_Leave);
            // 
            // textBox_NhapB
            // 
            this.textBox_NhapB.Location = new System.Drawing.Point(239, 188);
            this.textBox_NhapB.Name = "textBox_NhapB";
            this.textBox_NhapB.Size = new System.Drawing.Size(453, 20);
            this.textBox_NhapB.TabIndex = 5;
            this.textBox_NhapB.Leave += new System.EventHandler(this.textBox_NhapB_Leave);
            // 
            // textBox_Nghiem
            // 
            this.textBox_Nghiem.Enabled = false;
            this.textBox_Nghiem.Location = new System.Drawing.Point(239, 243);
            this.textBox_Nghiem.Name = "textBox_Nghiem";
            this.textBox_Nghiem.Size = new System.Drawing.Size(453, 20);
            this.textBox_Nghiem.TabIndex = 6;
            // 
            // button_Giai
            // 
            this.button_Giai.Enabled = false;
            this.button_Giai.Location = new System.Drawing.Point(157, 350);
            this.button_Giai.Name = "button_Giai";
            this.button_Giai.Size = new System.Drawing.Size(75, 31);
            this.button_Giai.TabIndex = 7;
            this.button_Giai.Text = "&Giải";
            this.button_Giai.UseVisualStyleBackColor = true;
            this.button_Giai.Click += new System.EventHandler(this.button_Giai_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Enabled = false;
            this.button_Xoa.Location = new System.Drawing.Point(373, 350);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 31);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "&Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(581, 350);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 31);
            this.button_Thoat.TabIndex = 9;
            this.button_Thoat.Text = "&Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Giai);
            this.Controls.Add(this.textBox_Nghiem);
            this.Controls.Add(this.textBox_NhapB);
            this.Controls.Add(this.textBox_NhapA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc nhất";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nghiem;
        private System.Windows.Forms.TextBox textBox_NhapB;
        private System.Windows.Forms.TextBox textBox_NhapA;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Giai;
    }
}

