using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Exercice2
{
    public partial class EcranList : Form
    {
        string filename = null;
        private string file = null;


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;
        public EcranList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Activer(bool isActive)
        {
            if (isActive == true)
            {
                gbDetail.Enabled = false;
                lFichier.Enabled = true;
                lbPersonne.Enabled = true;
                bOuvrir.Enabled = true;
                bAjouter.Enabled = true;
                bSupprimer.Enabled = true;
                bEnregistrer.Enabled = true;
                bModifier.Enabled = true;
            }
            else
            {
                gbDetail.Enabled = true;
                lFichier.Enabled = false;
                lbPersonne.Enabled = false;
                bOuvrir.Enabled = false;
                bAjouter.Enabled = false;
                bSupprimer.Enabled = false;
                bEnregistrer.Enabled = false;
                bModifier.Enabled = false;
            }
        }

        private void EcranList_Load(object sender, EventArgs e)
        {
            Activer(true);

        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int i = lbPersonne.SelectedIndex;
                String resultat = $"{tbNom.Text} ({cbQualite.Text})";
                lbPersonne.Items[i] = resultat;
                Activer(true);
            }
            else
            {
                String resultat = $"{tbNom.Text} ({cbQualite.Text})";
                lbPersonne.Items.Add(resultat);
                Activer(true);
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                filename = ofdOuvrir.FileName;

                // Vide la liste actuelle avant de charger le fichier
                lbPersonne.Items.Clear();

                // Lecture du fichier texte
                string[] lignes = System.IO.File.ReadAllLines(filename);
                foreach (string ligne in lignes)
                {
                    lbPersonne.Items.Add(ligne);
                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            sfdEnregistrer.FileName = "personnes.txt";
            sfdEnregistrer.DefaultExt = "txt";
            sfdEnregistrer.Filter = "Text files (*.txt)|*.txt";

            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                // Use the filename chosen in the SaveFileDialog
                filename = sfdEnregistrer.FileName;

                file = "";

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    file += lbPersonne.Items[i].ToString() + Environment.NewLine;
                    System.Diagnostics.Debug.WriteLine(lbPersonne.Items[i].ToString());
                }
                File.WriteAllText(filename, file.ToString());

                lbPersonne.Items.Clear();
            }


        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            int index = lbPersonne.SelectedIndex;
            String data = lbPersonne.Items[index].ToString();


            MessageBox.Show($"Données : {data}\n" +
                        $"Index : {index}\n");
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int i = lbPersonne.SelectedIndex;
                string ligne = lbPersonne.Items[i].ToString();
                int indexParenthese = ligne.LastIndexOf(" (");

                tbNom.Text = ligne.Substring(0, indexParenthese);

                cbQualite.Text = ligne.Substring(indexParenthese + 2).Replace(")", "");

                Activer(false);

               
    }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne à modifier.");
            }

        }
    }
}
