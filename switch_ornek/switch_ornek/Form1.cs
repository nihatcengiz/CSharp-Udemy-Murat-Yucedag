using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "ocak"; break;
                case 2: label2.Text = "subat"; break;
                case 3: label2.Text = "mart"; break;
                case 4: label2.Text = "nisan"; break;
                case 5: label2.Text = "mayıs"; break;
                case 6: label2.Text = "haziran"; break;
                case 7: label2.Text = "temmuz"; break;
                case 8: label2.Text = "agustos"; break;
                case 9: label2.Text = "eylül"; break;
                case 10: label2.Text = "ekim"; break;
                case 11: label2.Text = "kasım"; break;
                case 12: label2.Text = "aralık"; break;
                default: label2.Text = "hata"; break;




            }
        }
    }
}
