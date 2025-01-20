namespace калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.nPLU = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.nMIN = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.nSLA = new System.Windows.Forms.Button();
            this.nMUL = new System.Windows.Forms.Button();
            this.nC = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(89, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.n1.Location = new System.Drawing.Point(90, 69);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(52, 47);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n4.Location = new System.Drawing.Point(89, 147);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(52, 47);
            this.n4.TabIndex = 2;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n2.Location = new System.Drawing.Point(178, 69);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(52, 47);
            this.n2.TabIndex = 3;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n5.Location = new System.Drawing.Point(178, 147);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(52, 47);
            this.n5.TabIndex = 4;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n3.Location = new System.Drawing.Point(257, 69);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(52, 47);
            this.n3.TabIndex = 5;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // nPLU
            // 
            this.nPLU.BackColor = System.Drawing.Color.IndianRed;
            this.nPLU.Location = new System.Drawing.Point(332, 69);
            this.nPLU.Name = "nPLU";
            this.nPLU.Size = new System.Drawing.Size(52, 47);
            this.nPLU.TabIndex = 6;
            this.nPLU.Text = "+";
            this.nPLU.UseVisualStyleBackColor = false;
            this.nPLU.Click += new System.EventHandler(this.nPLU_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n6.Location = new System.Drawing.Point(257, 147);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(52, 47);
            this.n6.TabIndex = 7;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // nMIN
            // 
            this.nMIN.BackColor = System.Drawing.Color.IndianRed;
            this.nMIN.Location = new System.Drawing.Point(332, 147);
            this.nMIN.Name = "nMIN";
            this.nMIN.Size = new System.Drawing.Size(52, 47);
            this.nMIN.TabIndex = 8;
            this.nMIN.Text = "-";
            this.nMIN.UseVisualStyleBackColor = false;
            this.nMIN.Click += new System.EventHandler(this.nMIN_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n9.Location = new System.Drawing.Point(257, 219);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(52, 47);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // nSLA
            // 
            this.nSLA.BackColor = System.Drawing.Color.IndianRed;
            this.nSLA.Location = new System.Drawing.Point(332, 219);
            this.nSLA.Name = "nSLA";
            this.nSLA.Size = new System.Drawing.Size(52, 47);
            this.nSLA.TabIndex = 10;
            this.nSLA.Text = "/";
            this.nSLA.UseVisualStyleBackColor = false;
            this.nSLA.Click += new System.EventHandler(this.nSLA_Click);
            // 
            // nMUL
            // 
            this.nMUL.BackColor = System.Drawing.Color.IndianRed;
            this.nMUL.Location = new System.Drawing.Point(332, 297);
            this.nMUL.Name = "nMUL";
            this.nMUL.Size = new System.Drawing.Size(52, 47);
            this.nMUL.TabIndex = 11;
            this.nMUL.Text = "*";
            this.nMUL.UseVisualStyleBackColor = false;
            this.nMUL.Click += new System.EventHandler(this.nMUL_Click);
            // 
            // nC
            // 
            this.nC.BackColor = System.Drawing.Color.RosyBrown;
            this.nC.Location = new System.Drawing.Point(257, 297);
            this.nC.Name = "nC";
            this.nC.Size = new System.Drawing.Size(52, 47);
            this.nC.TabIndex = 12;
            this.nC.Text = "C";
            this.nC.UseVisualStyleBackColor = false;
            this.nC.Click += new System.EventHandler(this.nC_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n8.Location = new System.Drawing.Point(178, 219);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(52, 47);
            this.n8.TabIndex = 13;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n7.Location = new System.Drawing.Point(90, 219);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(52, 47);
            this.n7.TabIndex = 14;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.RosyBrown;
            this.button15.Location = new System.Drawing.Point(178, 297);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 47);
            this.button15.TabIndex = 15;
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n0.Location = new System.Drawing.Point(90, 297);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(52, 47);
            this.n0.TabIndex = 16;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // nEnter
            // 
            this.nEnter.BackColor = System.Drawing.Color.DarkOrange;
            this.nEnter.Location = new System.Drawing.Point(90, 374);
            this.nEnter.Name = "nEnter";
            this.nEnter.Size = new System.Drawing.Size(294, 47);
            this.nEnter.TabIndex = 17;
            this.nEnter.Text = "=";
            this.nEnter.UseVisualStyleBackColor = false;
            this.nEnter.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nEnter);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.nC);
            this.Controls.Add(this.nMUL);
            this.Controls.Add(this.nSLA);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.nMIN);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.nPLU);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button nPLU;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button nMIN;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button nSLA;
        private System.Windows.Forms.Button nMUL;
        private System.Windows.Forms.Button nC;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nEnter;
    }
}

