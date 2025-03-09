namespace CurrencyConverterItSchoolProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(346, 165);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(268, 29);
            textBox1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(44, 165);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(268, 29);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(346, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 29);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 29);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(44, 19);
            label2.Name = "label2";
            label2.Size = new Size(199, 21);
            label2.TabIndex = 1;
            label2.Text = "Currency to convert from:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(346, 129);
            label5.Name = "label5";
            label5.Size = new Size(151, 21);
            label5.TabIndex = 4;
            label5.Text = "Converted amount:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(346, 19);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 2;
            label3.Text = "Currency to convert to:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(44, 129);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 3;
            label4.Text = "Amount to convert:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 15);
            label1.Name = "label1";
            label1.Size = new Size(601, 86);
            label1.TabIndex = 0;
            label1.Text = "Currency Converter";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(61, 132);
            panel1.MinimumSize = new Size(649, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 223);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(317, 372);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 7;
            button1.Text = "CONVERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(0, 437);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 500);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(20, 226);
            button6.Name = "button6";
            button6.Size = new Size(365, 38);
            button6.TabIndex = 7;
            button6.Text = "Swiss Franc to Romanian Leu";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(20, 182);
            button5.Name = "button5";
            button5.Size = new Size(365, 38);
            button5.TabIndex = 6;
            button5.Text = "Pound Sterling to Romanian Leu";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(20, 138);
            button4.Name = "button4";
            button4.Size = new Size(365, 38);
            button4.TabIndex = 5;
            button4.Text = "American Dollar to Romanian Leu";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(20, 94);
            button3.Name = "button3";
            button3.Size = new Size(365, 38);
            button3.TabIndex = 4;
            button3.Text = "Romanian Leu to Euro";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(20, 50);
            button2.Name = "button2";
            button2.Size = new Size(365, 38);
            button2.TabIndex = 3;
            button2.Text = "Euro to Romanian Leu";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 16);
            label7.Name = "label7";
            label7.Size = new Size(165, 21);
            label7.TabIndex = 2;
            label7.Text = "Popular conversions";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(420, 16);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 1;
            label6.Text = "Latest conversions";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(419, 50);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 214);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Gold;
            ClientSize = new Size(780, 457);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label6;
        private TextBox textBox2;
        private Button button2;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button5;
    }
}
