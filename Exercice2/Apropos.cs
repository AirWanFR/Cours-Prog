using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using MainMenu.Properties;

namespace MainMenu
{
    public partial class Apropos : Form
    {
        private Cursor curseurOrigine;
        

        public Apropos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bouton_MouseEnter(object sender, EventArgs e)
        {
            curseurOrigine = this.Cursor; 
            this.Cursor = Cursors.Hand;   
        }

        private void Bouton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = curseurOrigine; 
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            curseurOrigine = this.Cursor;
            Bitmap bmp = Properties.Resources.cursor;
            IntPtr ptr = bmp.GetHicon();
            Cursor curseurPerso = new Cursor(ptr);
            this.Cursor = curseurPerso;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = curseurOrigine;
        }



    }
}
