
namespace UI_pokusaj.Forms
{
    partial class FormKontaktZakazivanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRazlogPregledaUnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOtkaziPregled = new System.Windows.Forms.Button();
            this.buttonZakazi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBrojTelefonaUnos = new System.Windows.Forms.TextBox();
            this.bazaDataSet1 = new UI_pokusaj.BazaDataSet();
            this.bindingSourceVlasnik = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.VlasnikTableAdapter();
            this.bindingSourceZivotinja = new System.Windows.Forms.BindingSource(this.components);
            this.ljubimacTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.LjubimacTableAdapter();
            this.textBoxImeZivotinje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIzborVeterinara = new System.Windows.Forms.ComboBox();
            this.bindingSourceVeterinar = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxUnosVrsteZivotinje = new System.Windows.Forms.TextBox();
            this.veterinarTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.VeterinarTableAdapter();
            this.textBoxPrezimeVlasnika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeterinar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVlasnik
            // 
            this.textBoxVlasnik.Location = new System.Drawing.Point(418, 47);
            this.textBoxVlasnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVlasnik.Name = "textBoxVlasnik";
            this.textBoxVlasnik.Size = new System.Drawing.Size(245, 22);
            this.textBoxVlasnik.TabIndex = 0;
            this.textBoxVlasnik.TextChanged += new System.EventHandler(this.textBoxVlasnik_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime vlasnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta zivotinje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Veterinar";
            // 
            // textBoxRazlogPregledaUnos
            // 
            this.textBoxRazlogPregledaUnos.Location = new System.Drawing.Point(423, 247);
            this.textBoxRazlogPregledaUnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRazlogPregledaUnos.Name = "textBoxRazlogPregledaUnos";
            this.textBoxRazlogPregledaUnos.Size = new System.Drawing.Size(240, 22);
            this.textBoxRazlogPregledaUnos.TabIndex = 6;
            this.textBoxRazlogPregledaUnos.TextChanged += new System.EventHandler(this.textBoxRazlogPregledaUnos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pregled";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 352);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum";
            // 
            // buttonOtkaziPregled
            // 
            this.buttonOtkaziPregled.Location = new System.Drawing.Point(418, 390);
            this.buttonOtkaziPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOtkaziPregled.Name = "buttonOtkaziPregled";
            this.buttonOtkaziPregled.Size = new System.Drawing.Size(119, 43);
            this.buttonOtkaziPregled.TabIndex = 10;
            this.buttonOtkaziPregled.Text = "Otkazi Pregled";
            this.buttonOtkaziPregled.UseVisualStyleBackColor = true;
            this.buttonOtkaziPregled.Click += new System.EventHandler(this.buttonOtkaziPregled_Click);
            // 
            // buttonZakazi
            // 
            this.buttonZakazi.Location = new System.Drawing.Point(543, 390);
            this.buttonZakazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZakazi.Name = "buttonZakazi";
            this.buttonZakazi.Size = new System.Drawing.Size(119, 43);
            this.buttonZakazi.TabIndex = 11;
            this.buttonZakazi.Text = "Zakazi pregled";
            this.buttonZakazi.UseVisualStyleBackColor = true;
            this.buttonZakazi.Click += new System.EventHandler(this.buttonZakazi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj telefona";
            // 
            // textBoxBrojTelefonaUnos
            // 
            this.textBoxBrojTelefonaUnos.Location = new System.Drawing.Point(419, 125);
            this.textBoxBrojTelefonaUnos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrojTelefonaUnos.Name = "textBoxBrojTelefonaUnos";
            this.textBoxBrojTelefonaUnos.Size = new System.Drawing.Size(243, 22);
            this.textBoxBrojTelefonaUnos.TabIndex = 13;
            this.textBoxBrojTelefonaUnos.TextChanged += new System.EventHandler(this.textBoxBrojTelefonaUnos_TextChanged);
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "BazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceVlasnik
            // 
            this.bindingSourceVlasnik.DataMember = "Vlasnik";
            this.bindingSourceVlasnik.DataSource = this.bazaDataSet1;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceZivotinja
            // 
            this.bindingSourceZivotinja.DataMember = "Ljubimac";
            this.bindingSourceZivotinja.DataSource = this.bazaDataSet1;
            this.bindingSourceZivotinja.CurrentChanged += new System.EventHandler(this.bindingSourceZivotinja_CurrentChanged);
            // 
            // ljubimacTableAdapter
            // 
            this.ljubimacTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxImeZivotinje
            // 
            this.textBoxImeZivotinje.Location = new System.Drawing.Point(422, 209);
            this.textBoxImeZivotinje.Name = "textBoxImeZivotinje";
            this.textBoxImeZivotinje.Size = new System.Drawing.Size(240, 22);
            this.textBoxImeZivotinje.TabIndex = 14;
            this.textBoxImeZivotinje.TextChanged += new System.EventHandler(this.textBoxImeZivotinje_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ime zivotinje";
            // 
            // comboBoxIzborVeterinara
            // 
            this.comboBoxIzborVeterinara.DataSource = this.bindingSourceVeterinar;
            this.comboBoxIzborVeterinara.DisplayMember = "Ime";
            this.comboBoxIzborVeterinara.FormattingEnabled = true;
            this.comboBoxIzborVeterinara.Location = new System.Drawing.Point(422, 287);
            this.comboBoxIzborVeterinara.Name = "comboBoxIzborVeterinara";
            this.comboBoxIzborVeterinara.Size = new System.Drawing.Size(241, 24);
            this.comboBoxIzborVeterinara.TabIndex = 16;
            this.comboBoxIzborVeterinara.ValueMember = "VeterinarID";
            this.comboBoxIzborVeterinara.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzborVeterinara_SelectedIndexChanged);
            // 
            // bindingSourceVeterinar
            // 
            this.bindingSourceVeterinar.DataMember = "Veterinar";
            this.bindingSourceVeterinar.DataSource = this.bazaDataSet1;
            // 
            // textBoxUnosVrsteZivotinje
            // 
            this.textBoxUnosVrsteZivotinje.Location = new System.Drawing.Point(420, 166);
            this.textBoxUnosVrsteZivotinje.Name = "textBoxUnosVrsteZivotinje";
            this.textBoxUnosVrsteZivotinje.Size = new System.Drawing.Size(242, 22);
            this.textBoxUnosVrsteZivotinje.TabIndex = 17;
            this.textBoxUnosVrsteZivotinje.TextChanged += new System.EventHandler(this.textBoxUnosVrsteZivotinje_TextChanged);
            // 
            // veterinarTableAdapter
            // 
            this.veterinarTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPrezimeVlasnika
            // 
            this.textBoxPrezimeVlasnika.Location = new System.Drawing.Point(419, 83);
            this.textBoxPrezimeVlasnika.Name = "textBoxPrezimeVlasnika";
            this.textBoxPrezimeVlasnika.Size = new System.Drawing.Size(243, 22);
            this.textBoxPrezimeVlasnika.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Prezime vlasnika";
            // 
            // FormKontaktZakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1063, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrezimeVlasnika);
            this.Controls.Add(this.textBoxUnosVrsteZivotinje);
            this.Controls.Add(this.comboBoxIzborVeterinara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxImeZivotinje);
            this.Controls.Add(this.textBoxBrojTelefonaUnos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonZakazi);
            this.Controls.Add(this.buttonOtkaziPregled);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRazlogPregledaUnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVlasnik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKontaktZakazivanje";
            this.Load += new System.EventHandler(this.FormKontaktZakazivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVlasnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeterinar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVlasnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRazlogPregledaUnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOtkaziPregled;
        private System.Windows.Forms.Button buttonZakazi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBrojTelefonaUnos;
        private BazaDataSet bazaDataSet1;
        private System.Windows.Forms.BindingSource bindingSourceVlasnik;
        private BazaDataSetTableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceZivotinja;
        private BazaDataSetTableAdapters.LjubimacTableAdapter ljubimacTableAdapter;
        private System.Windows.Forms.TextBox textBoxImeZivotinje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIzborVeterinara;
        private System.Windows.Forms.TextBox textBoxUnosVrsteZivotinje;
        private System.Windows.Forms.BindingSource bindingSourceVeterinar;
        private BazaDataSetTableAdapters.VeterinarTableAdapter veterinarTableAdapter;
        private System.Windows.Forms.TextBox textBoxPrezimeVlasnika;
        private System.Windows.Forms.Label label8;
    }
}