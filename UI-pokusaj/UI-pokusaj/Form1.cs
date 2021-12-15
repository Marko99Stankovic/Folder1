using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_pokusaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam,int lParam);

        //-----------------------------------------------------------
        public void loadform(object Form)
        {
            if (this.panelForma.Controls.Count > 0)
                this.panelForma.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelForma.Controls.Add(f);
            this.panelForma.Tag = f;
            f.Show();

        }
        //----------------------------------------------------------
        private void buttonZdravlje_Click(object sender, EventArgs e)
        {
            loadform(new Forms.FormZdravlje());
            labelBar1.Text = "Zdravlje";
        }
        private void buttonMedikament_Click(object sender, EventArgs e)
        {
            loadform(new Forms.FormMedikamentiProdavnica());
            labelBar1.Text = "VetShop";
        }
        private void buttonZakazi_Click(object sender, EventArgs e)
        {
            loadform(new Forms.FormKontaktZakazivanje());
            labelBar1.Text = "Zakazivanje";
        }
        private void buttonZivotinje_Click(object sender, EventArgs e)
        {
            loadform(new Forms.FormOnama());
            //promeni labelu
            labelBar1.Text = "Istorija vaseg ljubimca";
            
        }
        //------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
