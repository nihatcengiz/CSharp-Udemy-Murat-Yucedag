using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter degisken;

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            degisken =File.CreateText(dosyayolu + "\\" +dosyaadi + ".txt");
            degisken.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir =sr.ReadLine();
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Metin Dosyalar|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Kayıt Oluşturuldu.");
        }
    }
}
