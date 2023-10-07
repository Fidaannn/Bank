namespace Winforms712
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(223, 96);
            label1.Name = "label1";
            label1.Size = new Size(423, 60);
            label1.TabIndex = 0;
            label1.Text = "Məbləği daxil edin:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(203, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 66);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 265);
            label2.Name = "label2";
            label2.Size = new Size(556, 37);
            label2.TabIndex = 3;
            label2.Text = "Balansınızda kifayət qədər məbləğ yoxdur";
            // 
            // button1
            // 
            button1.Location = new Point(406, 312);
            button1.Name = "button1";
            button1.Size = new Size(188, 61);
            button1.TabIndex = 1;
            button1.Text = "Təstiq et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 312);
            button2.Name = "button2";
            button2.Size = new Size(188, 61);
            button2.TabIndex = 4;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(26F, 60F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(908, 565);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(9);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}