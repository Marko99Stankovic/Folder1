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

        }

        private void buttonPoruci_Click(object sender, EventArgs e)
        {
            if(comboBoxProizvodi.Text !="")
            MessageBox.Show($"Porucen je {comboBoxProizvodi.Text}","Zavrsena kupovina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPovecajKolicinu(object sender, EventArgs e)
        {
            int a = 0;
            a = Int32.Parse(textBoxTrenutnaKolicina.Text);
            a++;
            textBoxTrenutnaKolicina.Text = a.ToString();
            
            
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
        }

        private void btnOtkaziKupovinu_Click(object sender, EventArgs e)
        {
            //ne upisuje nista u bazu
        }

        private void checkBoxPouzecem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOnlinePlacanje_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCENA_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
             bindingSourceCena.Filter = string.Format("Cena = {0}", comboBoxProizvodi.SelectedValue ?? 0);
            
            //za mnozenje sa kolicinom ce biti potrebne konverzije to int...ili nesto slicno
            textBoxCENA.Text = "cena proizvoda" ;
        
        }
    }
}
