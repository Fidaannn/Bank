namespace Winforms712
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(181, 268);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = 'x';
            textBox1.Size = new Size(428, 87);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(624, 60);
            label1.TabIndex = 1;
            label1.Text = "Bizim Banka Xoş Gəlmişsiniz.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(490, 60);
            label2.TabIndex = 2;
            label2.Text = "Parolunuzu daxil edin.";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(258, 419);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(250, 66);
            button1.TabIndex = 3;
            button1.Text = "Təstiq";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(258, 371);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(271, 37);
            label3.TabIndex = 4;
            label3.Text = "Parolunuz yalnışdır!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(36F, 81F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(803, 498);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(13, 11, 13, 11);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}