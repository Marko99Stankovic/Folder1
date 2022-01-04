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
    public partial class FormOnama : Form
    {
        public FormOnama()
        {
            InitializeComponent();
        }

        private void FormOnama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet1.Ljubimac' table. You can move, or remove it, as needed.
            this.ljubimacTableAdapter.Fill(this.bazaDataSet1.Ljubimac);
            // TODO: This line of code loads data into the 'bazaDataSet1.Pregledi' table. You can move, or remove it, as needed.
            this.preglediTableLjubimci.Fill(this.bazaDataSet1.Pregledi);

            comboBox1_SelectedIndexChanged(comboBox1, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceRazlog.Filter = string.Format("LjubimacID = {0}", comboBox1.SelectedValue ?? 0);
                
        }

        private void listBoxISTORIJA_SelectedIndexChanged(object sender, EventArgs e)
        {
           // bindingSourceLjubimci.Filter = string.Format("LjubimacID={0}", listBoxISTORIJA.SelectedValue ?? 0); //pravi bug|selekcijom el u listboxu ogranici pristup ljubimcima...
           // razmotri mogucnost da ovo bude personalizovano| ulogovani korisnik moze videti istoriju samo za svoje zovotinje!!!!!!!!!!!
        }

        private void bindingSourceRazlog_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
 