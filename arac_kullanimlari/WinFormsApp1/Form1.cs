namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
            label3.Text = "Nihat Cengiz";
            label4.Text = "Pamuk";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Deneme";
            label5.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(dateTimePicker1.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}