namespace Winforms712
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "4004";
            string input = textBox1.Text;

            if (input == password)
            {
                Form2 next = new Form2();
                next.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}