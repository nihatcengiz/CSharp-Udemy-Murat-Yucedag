using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 1; i < 6; i++)
            {
                toplam = toplam + i;
                
            }
            label1.Text = toplam.ToString();
            listBox1.Items.Add(toplam);
        }

        private void button2_Click(object sender, EventArgs e)

        {
            int i = 1;
            while ( i < 5)
            {
                listBox2.Items.Add(i);
                i++;
            }
        }
    }
}
