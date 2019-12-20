namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.factBtn = new System.Windows.Forms.Button();
            this.sqrtTwoBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.medianaBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.powCertBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.Label();
            this.EQUAL = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(277, 201);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(69, 39);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(277, 261);
            this.minusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(69, 43);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Location = new System.Drawing.Point(364, 201);
            this.MultBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(69, 39);
            this.MultBtn.TabIndex = 5;
            this.MultBtn.Text = "*";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(277, 322);
            this.divBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(69, 44);
            this.divBtn.TabIndex = 6;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // factBtn
            // 
            this.factBtn.Location = new System.Drawing.Point(277, 382);
            this.factBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.factBtn.Name = "factBtn";
            this.factBtn.Size = new System.Drawing.Size(69, 44);
            this.factBtn.TabIndex = 7;
            this.factBtn.Text = "!";
            this.factBtn.UseVisualStyleBackColor = true;
            this.factBtn.Click += new System.EventHandler(this.factBtn_Click);
            // 
            // sqrtTwoBtn
            // 
            this.sqrtTwoBtn.Location = new System.Drawing.Point(364, 382);
            this.sqrtTwoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqrtTwoBtn.Name = "sqrtTwoBtn";
            this.sqrtTwoBtn.Size = new System.Drawing.Size(69, 44);
            this.sqrtTwoBtn.TabIndex = 8;
            this.sqrtTwoBtn.Text = "Sqrt(2)";
            this.sqrtTwoBtn.UseVisualStyleBackColor = true;
            this.sqrtTwoBtn.Click += new System.EventHandler(this.sqrtTwoBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Location = new System.Drawing.Point(451, 382);
            this.sqrtBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(69, 44);
            this.sqrtBtn.TabIndex = 9;
            this.sqrtBtn.Text = "Sqrt()";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(451, 322);
            this.logBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(69, 43);
            this.logBtn.TabIndex = 10;
            this.logBtn.Text = "Log";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // medianaBtn
            // 
            this.medianaBtn.Location = new System.Drawing.Point(451, 261);
            this.medianaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medianaBtn.Name = "medianaBtn";
            this.medianaBtn.Size = new System.Drawing.Size(69, 43);
            this.medianaBtn.TabIndex = 11;
            this.medianaBtn.Text = "Mediana";
            this.medianaBtn.UseVisualStyleBackColor = true;
            this.medianaBtn.Click += new System.EventHandler(this.medianaBtn_Click);
            // 
            // powBtn
            // 
            this.powBtn.Location = new System.Drawing.Point(364, 322);
            this.powBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(69, 44);
            this.powBtn.TabIndex = 12;
            this.powBtn.Text = "Pow(2)";
            this.powBtn.UseVisualStyleBackColor = true;
            this.powBtn.Click += new System.EventHandler(this.powBtn_Click);
            // 
            // powCertBtn
            // 
            this.powCertBtn.Location = new System.Drawing.Point(364, 261);
            this.powCertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powCertBtn.Name = "powCertBtn";
            this.powCertBtn.Size = new System.Drawing.Size(69, 43);
            this.powCertBtn.TabIndex = 13;
            this.powCertBtn.Text = "Pow()";
            this.powCertBtn.UseVisualStyleBackColor = true;
            this.powCertBtn.Click += new System.EventHandler(this.powCertBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(551, 52);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 352);
            this.textBox3.TabIndex = 14;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.AutoSize = true;
            this.ResultTextBox.Location = new System.Drawing.Point(548, 17);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(69, 17);
            this.ResultTextBox.TabIndex = 15;
            this.ResultTextBox.Text = "HISTORY";
            this.ResultTextBox.Click += new System.EventHandler(this.ResultTextBox_Click);
            // 
            // EQUAL
            // 
            this.EQUAL.Location = new System.Drawing.Point(451, 53);
            this.EQUAL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EQUAL.Name = "EQUAL";
            this.EQUAL.Size = new System.Drawing.Size(69, 115);
            this.EQUAL.TabIndex = 16;
            this.EQUAL.Text = "=";
            this.EQUAL.UseVisualStyleBackColor = true;
            this.EQUAL.Click += new System.EventHandler(this.EQUAL_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 201);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 261);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 261);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 43);
            this.button6.TabIndex = 22;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(185, 261);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 43);
            this.button7.TabIndex = 23;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 322);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(96, 322);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 44);
            this.button9.TabIndex = 25;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(185, 322);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 44);
            this.button10.TabIndex = 26;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(96, 382);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 44);
            this.button11.TabIndex = 27;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 382);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 44);
            this.button12.TabIndex = 28;
            this.button12.Text = ",";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(185, 382);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 44);
            this.button13.TabIndex = 29;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 439);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EQUAL);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.powCertBtn);
            this.Controls.Add(this.powBtn);
            this.Controls.Add(this.medianaBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.sqrtTwoBtn);
            this.Controls.Add(this.factBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button factBtn;
        private System.Windows.Forms.Button sqrtTwoBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button medianaBtn;
        private System.Windows.Forms.Button powBtn;
        private System.Windows.Forms.Button powCertBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ResultTextBox;
        private System.Windows.Forms.Button EQUAL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

