using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms712
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            int balance = 100;

            int mebleg = (int)Convert.ToInt64(textBox1.Text);


            if (balance >= mebleg)
            {
                int netice = balance - mebleg;

                form4.label1.Text = $"Sizin Balans : {netice.ToString()}";

                form4.Show();
                this.Hide();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            back.Show();
            this.Hide();
        }
    }
}
