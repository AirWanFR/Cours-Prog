using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class FicClavierSouris : Form
    {
        private int nbGauche;
        private int nbDroit;
        public FicClavierSouris()
        {
            InitializeComponent();
            nbDroit = 0;
            nbGauche = 0;
        }

        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbDroit = 0;
            nbGauche = 0;

            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";

            lsbClavier.Items.Clear();
            afficherClic();
        }

        private void pnlSouris_MouseClick(object sender, MouseEventArgs e)
        {
            int ligne = (e.Y / (pnlSouris.Height / 3)) + 1;
            int colonne = (e.X / (pnlSouris.Width / 3)) + 1;

            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;
                lsbClavier.Items.Insert(0, $"Clic Gauche dans Case : Ligne {ligne}, Col {colonne}");

            }
            else if (e.Button == MouseButtons.Right)
            {
                nbDroit++;
                lsbClavier.Items.Insert(0, $"Clic Droit dans Case : Ligne {ligne}, Col {colonne}");

            }


            afficherClic();


        }

        private void afficherClic()
        {
            tbxClicDroit.Text = nbDroit.ToString();
            tbxClicGauche.Text = nbGauche.ToString();
        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void FicClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            string info = $"Down: {e.KeyCode} | Shift: {e.Shift} | Val: {e.KeyValue}";
            lsbClavier.Items.Insert(0, info);
        }

        private void FicClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            string info = $"Press: {e.KeyChar}";
            lsbClavier.Items.Insert(0, info);
        }

        private void FicClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            string info = $"Up: {e.KeyCode} | Shift: {e.Shift} | Val: {e.KeyValue}";
            lsbClavier.Items.Insert(0, info);
        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {
            Pen monCrayon = new Pen(Color.Black, 1);
            Graphics g = e.Graphics;

            g.DrawLine(monCrayon, pnlSouris.Width / 3, 0, pnlSouris.Width / 3, pnlSouris.Height);
            g.DrawLine(monCrayon, (2 * pnlSouris.Width) / 3, 0, (2 * pnlSouris.Width) / 3, pnlSouris.Height);

            g.DrawLine(monCrayon, 0, pnlSouris.Height / 3, pnlSouris.Width, pnlSouris.Height / 3);
            g.DrawLine(monCrayon, 0, (2 * pnlSouris.Height) / 3, pnlSouris.Width, (2 * pnlSouris.Height) / 3);
        }
    }
}
