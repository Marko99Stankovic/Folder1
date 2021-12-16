
namespace UI_pokusaj.Forms
{
    partial class FormOnama
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxISTORIJA = new System.Windows.Forms.ListBox();
            this.bazaDataSet1 = new UI_pokusaj.BazaDataSet();
            this.bindingSourceLjubimci = new System.Windows.Forms.BindingSource(this.components);
            this.preglediTableLjubimci = new UI_pokusaj.BazaDataSetTableAdapters.PreglediTableAdapter();
            this.bindingSourceRazlog = new System.Windows.Forms.BindingSource(this.components);
            this.ljubimacTableAdapter = new UI_pokusaj.BazaDataSetTableAdapters.LjubimacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRazlog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Istorija ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSourceLjubimci;
            this.comboBox1.DisplayMember = "Ime";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "LjubimacID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite životinju";
            // 
            // listBoxISTORIJA
            // 
            this.listBoxISTORIJA.DataSource = this.bindingSourceRazlog;
            this.listBoxISTORIJA.DisplayMember = "Razlog";
            this.listBoxISTORIJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxISTORIJA.FormattingEnabled = true;
            this.listBoxISTORIJA.ItemHeight = 18;
            this.listBoxISTORIJA.Location = new System.Drawing.Point(279, 145);
            this.listBoxISTORIJA.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxISTORIJA.Name = "listBoxISTORIJA";
            this.listBoxISTORIJA.Size = new System.Drawing.Size(392, 346);
            this.listBoxISTORIJA.TabIndex = 4;
            this.listBoxISTORIJA.ValueMember = "LjubimacID";
            this.listBoxISTORIJA.SelectedIndexChanged += new System.EventHandler(this.listBoxISTORIJA_SelectedIndexChanged);
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "BazaDataSet";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceLjubimci
            // 
            this.bindingSourceLjubimci.DataMember = "Ljubimac";
            this.bindingSourceLjubimci.DataSource = this.bazaDataSet1;
            // 
            // preglediTableLjubimci
            // 
            this.preglediTableLjubimci.ClearBeforeFill = true;
            // 
            // bindingSourceRazlog
            // 
            this.bindingSourceRazlog.DataMember = "Pregledi";
            this.bindingSourceRazlog.DataSource = this.bazaDataSet1;
            this.bindingSourceRazlog.CurrentChanged += new System.EventHandler(this.bindingSourceRazlog_CurrentChanged);
            // 
            // ljubimacTableAdapter
            // 
            this.ljubimacTableAdapter.ClearBeforeFill = true;
            // 
            // FormOnama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(876, 683);
            this.Controls.Add(this.listBoxISTORIJA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOnama";
            this.Text = "FormOnama";
            this.Load += new System.EventHandler(this.FormOnama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLjubimci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRazlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxISTORIJA;
        private BazaDataSet bazaDataSet1;
        private System.Windows.Forms.BindingSource bindingSourceLjubimci;
        private BazaDataSetTableAdapters.PreglediTableAdapter preglediTableLjubimci;
        private System.Windows.Forms.BindingSource bindingSourceRazlog;
        private BazaDataSetTableAdapters.LjubimacTableAdapter ljubimacTableAdapter;
    }
}