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

        }

        private void buttonPoruci_Click(object sender, EventArgs e)
        {
            //moguce je poruciti ako su sva polja popunjena!!! ! !  ! ! !  ! ! !  ! ! ! !  ! !
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
    }
}
