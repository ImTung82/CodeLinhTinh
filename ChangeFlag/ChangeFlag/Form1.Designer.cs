namespace ChangeFlag
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
            this.pictureBox_Flag = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Vietnam = new System.Windows.Forms.RadioButton();
            this.radioButton_USA = new System.Windows.Forms.RadioButton();
            this.radioButton_ITalian = new System.Windows.Forms.RadioButton();
            this.radioButton_Philippines = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Flag
            // 
            this.pictureBox_Flag.Location = new System.Drawing.Point(394, 140);
            this.pictureBox_Flag.Name = "pictureBox_Flag";
            this.pictureBox_Flag.Size = new System.Drawing.Size(361, 187);
            this.pictureBox_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Flag.TabIndex = 0;
            this.pictureBox_Flag.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Philippines);
            this.groupBox1.Controls.Add(this.radioButton_ITalian);
            this.groupBox1.Controls.Add(this.radioButton_USA);
            this.groupBox1.Controls.Add(this.radioButton_Vietnam);
            this.groupBox1.Location = new System.Drawing.Point(45, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radioButton_Vietnam
            // 
            this.radioButton_Vietnam.AutoSize = true;
            this.radioButton_Vietnam.Location = new System.Drawing.Point(7, 36);
            this.radioButton_Vietnam.Name = "radioButton_Vietnam";
            this.radioButton_Vietnam.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Vietnam.TabIndex = 0;
            this.radioButton_Vietnam.TabStop = true;
            this.radioButton_Vietnam.Text = "Vietnam";
            this.radioButton_Vietnam.UseVisualStyleBackColor = true;
            this.radioButton_Vietnam.CheckedChanged += new System.EventHandler(this.radioButton_Vietnam_CheckedChanged);
            // 
            // radioButton_USA
            // 
            this.radioButton_USA.AutoSize = true;
            this.radioButton_USA.Location = new System.Drawing.Point(6, 93);
            this.radioButton_USA.Name = "radioButton_USA";
            this.radioButton_USA.Size = new System.Drawing.Size(47, 17);
            this.radioButton_USA.TabIndex = 1;
            this.radioButton_USA.TabStop = true;
            this.radioButton_USA.Text = "USA";
            this.radioButton_USA.UseVisualStyleBackColor = true;
            this.radioButton_USA.CheckedChanged += new System.EventHandler(this.radioButton_USA_CheckedChanged);
            // 
            // radioButton_ITalian
            // 
            this.radioButton_ITalian.AutoSize = true;
            this.radioButton_ITalian.Location = new System.Drawing.Point(6, 154);
            this.radioButton_ITalian.Name = "radioButton_ITalian";
            this.radioButton_ITalian.Size = new System.Drawing.Size(53, 17);
            this.radioButton_ITalian.TabIndex = 2;
            this.radioButton_ITalian.TabStop = true;
            this.radioButton_ITalian.Text = "Italian";
            this.radioButton_ITalian.UseVisualStyleBackColor = true;
            this.radioButton_ITalian.CheckedChanged += new System.EventHandler(this.radioButton_ITalian_CheckedChanged);
            // 
            // radioButton_Philippines
            // 
            this.radioButton_Philippines.AutoSize = true;
            this.radioButton_Philippines.Location = new System.Drawing.Point(7, 213);
            this.radioButton_Philippines.Name = "radioButton_Philippines";
            this.radioButton_Philippines.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Philippines.TabIndex = 3;
            this.radioButton_Philippines.TabStop = true;
            this.radioButton_Philippines.Text = "Philippines";
            this.radioButton_Philippines.UseVisualStyleBackColor = true;
            this.radioButton_Philippines.CheckedChanged += new System.EventHandler(this.radioButton_Philippines_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 89);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_Flag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Flag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Philippines;
        private System.Windows.Forms.RadioButton radioButton_ITalian;
        private System.Windows.Forms.RadioButton radioButton_USA;
        private System.Windows.Forms.RadioButton radioButton_Vietnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

