namespace Winforms712
{
    partial class Form2
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 32);
            label1.Name = "label1";
            label1.Size = new Size(281, 47);
            label1.TabIndex = 0;
            label1.Text = "Əməliyyat seçin";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(245, 127);
            button1.Name = "button1";
            button1.Size = new Size(286, 79);
            button1.TabIndex = 5;
            button1.Text = "Nağdlaşdırma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(245, 375);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(286, 79);
            button3.TabIndex = 7;
            button3.Text = "İmtina";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(245, 250);
            button2.Name = "button2";
            button2.Size = new Size(286, 79);
            button2.TabIndex = 8;
            button2.Text = "Balans";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(803, 498);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(9);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}