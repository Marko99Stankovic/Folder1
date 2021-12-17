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
    public partial class FormKontaktZakazivanje : Form
    {
        public FormKontaktZakazivanje()
        {
            InitializeComponent();
        }
        private void bindingSourceZivotinja_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormKontaktZakazivanje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet1.Veterinar' table. You can move, or remove it, as needed.
            this.veterinarTableAdapter.Fill(this.bazaDataSet1.Veterinar);

        }

        private void textBoxVlasnik_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnosVrsteZivotinje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImeZivotinje_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIzborVeterinara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRazlogPregledaUnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBrojTelefonaUnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZakazi_Click(object sender, EventArgs e)
        {
            //za svako polje odraditi ovo                                       //dodati za ostala polja
            if(textBoxVlasnik.Text !="" && textBoxBrojTelefonaUnos.Text != "" && textBoxPrezimeVlasnika.Text != "" && textBoxImeZivotinje.Text !="" )
            {
                //pravljenje novog reda
                var row = bazaDataSet1.Vlasnik.NewVlasnikRow();
                //popunjavanje row-a
                row.Ime = textBoxVlasnik.Text;
                row.Prezime = textBoxPrezimeVlasnika.Text;
                row.Broj_telefona = textBoxBrojTelefonaUnos.Text;

                //dodati ostala polja 







                //-------------------------------------------------------------------------------------------------------------
                //dodavanje u dataset
                bazaDataSet1.Vlasnik.AddVlasnikRow(row);
                //upis u bazu//azuriranje baze
                vlasnikTableAdapter.Update(bazaDataSet1);
                //textBoxVlasnik.Text = ""; //ovo nam ne treba //da ocisti polje za unos vlasnika nakon unosa vlasnika
                //-------------------------------------------------------------------------------------------------------------
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        private void buttonOtkaziPregled_Click(object sender, EventArgs e)
        {
            //?Razmotriti ovo----da li da brise iz baze poslednju unetu stavku klikom na dugme zakazi?
            //defaultno da bude disable, a nakon klika na zakazi postaje enable....--^
        }
    }
}
