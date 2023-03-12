namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        
        
        private void button1_Click(object sender, EventArgs e, int misir)
        {
            int misir = 0, bilet = 0, su = 0, cay = 0, toplam = 0;
            if (txtMisir.Text == "")

            {

                txtMisir.Text = "0";

            }

            if (txtBilet.Text == "")

            {

                txtBilet.Text = "0";

            }
            if (txtSu.Text == "")

            {

                txtSu.Text = "0";

            }
            if (txtCay.Text == "")

            {

                txtMisir.Text = "0";

            }

            misir = Convert.ToInt16(txtMisir);
            /*bilet = Convert.ToInt16(txtBilet);
            su = Convert.ToInt16(txtSu);
           cay = Convert.ToInt16(txtCay);*/
            toplam = misir * 4;
            lblTop.Text = toplam.ToString();

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString();


        }
    }
}