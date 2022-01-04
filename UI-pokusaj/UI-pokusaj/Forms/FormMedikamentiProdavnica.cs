using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_pokusaj.Forms
{
    public partial class FormMedikamentiProdavnica : Form
    {
        public FormMedikamentiProdavnica()
        {
            InitializeComponent();
        }

        private void FormMedikamentiProdavnica_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet1.Shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter.Fill(this.bazaDataSet1.Shop);
            comboBoxCena.Hide();
        }

        private void buttonPoruci_Click(object sender, EventArgs e)
        {
            if(comboBoxProizvodi.Text !="")
            MessageBox.Show($"Poruceno je {textBoxTrenutnaKolicina.Text} proizvoda {comboBoxProizvodi.Text} ","Zavrsena kupovina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            //da se doda nova tabela koja ce da belezi porudzbine 
        }

        private void buttonPovecajKolicinu(object sender, EventArgs e)
        {
            int a = 0;
            a = Int32.Parse(textBoxTrenutnaKolicina.Text);
            a++;
            textBoxTrenutnaKolicina.Text = a.ToString();
            textBoxCENA.Text = bindingSourceCena.ToString(); //a.ToString();                 //ovo se treba mnoziti sa cenom

        }

        private void btnSmanjiKolicinu_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = Int32.Parse(textBoxTrenutnaKolicina.Text);
            a--;
            if (a <= 0)
            {
                a = 0;
            }
            textBoxTrenutnaKolicina.Text = a.ToString();
            //textBoxCENA.Text = a.ToString();
            textBoxCENA.Text = bindingSourceCena.ToString();
        }

        private void btnOtkaziKupovinu_Click(object sender, EventArgs e)
        {
            //ne upisuje nista u bazu
        }

        private void textBoxCENA_TextChanged(object sender, EventArgs e)
        {
          
          //  textBoxCENA.Text = comboBoxCena.Text;
            int tmpcena = 0;
            int tmpkol = 1;
            tmpcena = Int32.Parse(comboBoxCena.Text);               
            tmpkol = Int32.Parse(textBoxTrenutnaKolicina.Text);
            tmpcena = tmpcena * tmpkol;
            textBoxCENA.Text = tmpcena.ToString();
        }

        private void comboBoxProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bindingSourceCena.Filter = string.Format("ShopID = {0}", comboBoxProizvodi.SelectedValue ?? 0);
            textBoxTrenutnaKolicina.Text = "1"; //reset nakon promene proizvoda |ovo ovako pise da bi radilo dugme +- posto ovaj text prebacuje u int...
            
            textBoxCENA.Text = comboBoxCena.Text;      //nakon svake promene proizvoda iz comboboxa u texbox za cenu se ispisuje cena po komadu
            
        }

        private void comboBoxCena_SelectedIndexChanged(object sender, EventArgs e)
        {
           //postoji samo zbog preuzimanja cene
        }

        private void radioButtonPouzece_CheckedChanged(object sender, EventArgs e)
        {
            //ako je cekirano, upisi u bazu izabran nacin plaanja
        }

        private void radioButtonOnline_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
