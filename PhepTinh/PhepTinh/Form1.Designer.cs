namespace PhepTinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_So1 = new System.Windows.Forms.TextBox();
            this.textBox_So2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_KetQua = new System.Windows.Forms.TextBox();
            this.radioButton_Cong = new System.Windows.Forms.RadioButton();
            this.radioButton_Tru = new System.Windows.Forms.RadioButton();
            this.radioButton_Nhan = new System.Windows.Forms.RadioButton();
            this.radioButton_Chia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // textBox_So1
            // 
            this.textBox_So1.Location = new System.Drawing.Point(201, 59);
            this.textBox_So1.Name = "textBox_So1";
            this.textBox_So1.Size = new System.Drawing.Size(517, 20);
            this.textBox_So1.TabIndex = 2;
            this.textBox_So1.TextChanged += new System.EventHandler(this.textBox_So1_TextChanged);
            // 
            // textBox_So2
            // 
            this.textBox_So2.Location = new System.Drawing.Point(201, 109);
            this.textBox_So2.Name = "textBox_So2";
            this.textBox_So2.Size = new System.Drawing.Size(517, 20);
            this.textBox_So2.TabIndex = 3;
            this.textBox_So2.TextChanged += new System.EventHandler(this.textBox_So1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Chia);
            this.groupBox1.Controls.Add(this.radioButton_Nhan);
            this.groupBox1.Controls.Add(this.radioButton_Tru);
            this.groupBox1.Controls.Add(this.radioButton_Cong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(112, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả:";
            // 
            // textBox_KetQua
            // 
            this.textBox_KetQua.Enabled = false;
            this.textBox_KetQua.Location = new System.Drawing.Point(201, 379);
            this.textBox_KetQua.Name = "textBox_KetQua";
            this.textBox_KetQua.Size = new System.Drawing.Size(517, 20);
            this.textBox_KetQua.TabIndex = 6;
            // 
            // radioButton_Cong
            // 
            this.radioButton_Cong.AutoSize = true;
            this.radioButton_Cong.Location = new System.Drawing.Point(7, 49);
            this.radioButton_Cong.Name = "radioButton_Cong";
            this.radioButton_Cong.Size = new System.Drawing.Size(69, 24);
            this.radioButton_Cong.TabIndex = 0;
            this.radioButton_Cong.TabStop = true;
            this.radioButton_Cong.Text = "Cộng";
            this.radioButton_Cong.UseVisualStyleBackColor = true;
            this.radioButton_Cong.CheckedChanged += new System.EventHandler(this.radioButton_Cong_CheckedChanged);
            // 
            // radioButton_Tru
            // 
            this.radioButton_Tru.AutoSize = true;
            this.radioButton_Tru.Location = new System.Drawing.Point(165, 49);
            this.radioButton_Tru.Name = "radioButton_Tru";
            this.radioButton_Tru.Size = new System.Drawing.Size(53, 24);
            this.radioButton_Tru.TabIndex = 1;
            this.radioButton_Tru.TabStop = true;
            this.radioButton_Tru.Text = "Trừ";
            this.radioButton_Tru.UseVisualStyleBackColor = true;
            this.radioButton_Tru.CheckedChanged += new System.EventHandler(this.radioButton_Tru_CheckedChanged);
            // 
            // radioButton_Nhan
            // 
            this.radioButton_Nhan.AutoSize = true;
            this.radioButton_Nhan.Location = new System.Drawing.Point(326, 49);
            this.radioButton_Nhan.Name = "radioButton_Nhan";
            this.radioButton_Nhan.Size = new System.Drawing.Size(69, 24);
            this.radioButton_Nhan.TabIndex = 2;
            this.radioButton_Nhan.TabStop = true;
            this.radioButton_Nhan.Text = "Nhân";
            this.radioButton_Nhan.UseVisualStyleBackColor = true;
            this.radioButton_Nhan.CheckedChanged += new System.EventHandler(this.radioButton_Nhan_CheckedChanged);
            // 
            // radioButton_Chia
            // 
            this.radioButton_Chia.AutoSize = true;
            this.radioButton_Chia.Location = new System.Drawing.Point(505, 49);
            this.radioButton_Chia.Name = "radioButton_Chia";
            this.radioButton_Chia.Size = new System.Drawing.Size(63, 24);
            this.radioButton_Chia.TabIndex = 3;
            this.radioButton_Chia.TabStop = true;
            this.radioButton_Chia.Text = "Chia";
            this.radioButton_Chia.UseVisualStyleBackColor = true;
            this.radioButton_Chia.CheckedChanged += new System.EventHandler(this.radioButton_Chia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_KetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_So2);
            this.Controls.Add(this.textBox_So1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_So1;
        private System.Windows.Forms.TextBox textBox_So2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Chia;
        private System.Windows.Forms.RadioButton radioButton_Nhan;
        private System.Windows.Forms.RadioButton radioButton_Tru;
        private System.Windows.Forms.RadioButton radioButton_Cong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_KetQua;
    }
}

