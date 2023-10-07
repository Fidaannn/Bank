namespace Winforms712
{
    partial class Form4
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 127);
            label1.Name = "label1";
            label1.Size = new Size(350, 47);
            label1.TabIndex = 0;
            label1.Text = "Sizin Balans: 100azn";
            // 
            // button1
            // 
            button1.Location = new Point(291, 238);
            button1.Name = "button1";
            button1.Size = new Size(212, 67);
            button1.TabIndex = 1;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(803, 498);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(9, 9, 9, 9);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Button button1;
    }
}