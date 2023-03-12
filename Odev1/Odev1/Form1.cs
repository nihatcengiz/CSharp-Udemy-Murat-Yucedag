namespace Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
        }
    }
}