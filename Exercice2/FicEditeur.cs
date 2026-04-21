using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class FicEditeur : Form
    {
        private string sFichier = "";
        private bool bModifier = false;
        public FicEditeur()
        {
            InitializeComponent();
        }

        private void FicEditeur_Load(object sender, EventArgs e)
        {
            sFichier = "";
            bModifier = false;
        }

        private bool FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                SaveFileDialog sdlg = new SaveFileDialog();
                sdlg.Filter = "Fichiers RTF (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt";

                if (sdlg.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sdlg.FileName;
                }
                else
                {
                    return false;
                }
            }

            if (Path.GetExtension(sFichier).ToLower() == ".rtf")
                rtbText.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            else
                rtbText.SaveFile(sFichier, RichTextBoxStreamType.PlainText);

            bModifier = false;
            return true;
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private bool VerifierSauver()
        {
            if (!bModifier)
                return true;

            DialogResult rep = MessageBox.Show(
                "Le document a été modifié. Voulez-vous l'enregistrer ?",
                "Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
                return FichierEnregistrer();

            if (rep == DialogResult.Cancel)
                return false;

            return true;
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
                return;

            rtbText.Clear();
            sFichier = "";
            bModifier = false;
        }

        private void Ouvrir_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver())
                return;

            ofdOuvrir.Filter = "Fichiers RTF (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt";
            ofdOuvrir.FileName = ""; 

            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOuvrir.FileName;

                if (Path.GetExtension(sFichier).ToLower() == ".rtf")
                    rtbText.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                else
                    rtbText.LoadFile(sFichier, RichTextBoxStreamType.PlainText);

                bModifier = false;
                this.Text = "FicEditeur - " + Path.GetFileName(sFichier);
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
                this.Close();
        }

        private void bCopier_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void bCouper_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void bColler_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void bJusGauche_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void bJusDroite_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void bJusCentre_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdPolice.Font = rtbText.SelectionFont;

            if (fdPolice.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionFont = fdPolice.Font;
            }

        }

        private void bCarGras_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(
                rtbText.SelectionFont,
                rtbText.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void bCarItalique_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(
                rtbText.SelectionFont,
                rtbText.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void bCarSouligne_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(
                rtbText.SelectionFont,
                rtbText.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void bCarBarre_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(
                rtbText.SelectionFont,
                rtbText.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            Nouveau_Click(this, EventArgs.Empty);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            Ouvrir_Click(this, EventArgs.Empty);
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer_Click(this, EventArgs.Empty);
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Quitter_Click(this, EventArgs.Empty);
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer_Click(this, EventArgs.Empty);
        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            Nouveau_Click((object)sender, EventArgs.Empty);
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            Ouvrir_Click(this, EventArgs.Empty);
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Quitter_Click((object)sender, EventArgs.Empty);
        }
    }
}
