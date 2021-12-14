
namespace UI_pokusaj.Forms
{
    partial class FormZdravlje
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
            this.labelZdravlje = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelZdravlje
            // 
            this.labelZdravlje.AutoSize = true;
            this.labelZdravlje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZdravlje.Location = new System.Drawing.Point(58, 7);
            this.labelZdravlje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZdravlje.Name = "labelZdravlje";
            this.labelZdravlje.Size = new System.Drawing.Size(545, 25);
            this.labelZdravlje.TabIndex = 0;
            this.labelZdravlje.Text = "10 znakova da kućnog ljubimca morate odvesti kod veterinara";
            this.labelZdravlje.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(62, 39);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 301);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FormZdravlje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(623, 390);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelZdravlje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormZdravlje";
            this.Text = "FormZdravlje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZdravlje;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}