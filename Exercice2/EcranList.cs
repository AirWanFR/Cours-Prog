using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

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

        int encodeNumber = 1;
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
            lbPersonne.Sorted = true;

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

                SendMessage(lbPersonne.Handle, smEcrire, i, encodeNumber);

                Activer(true);

                encodeNumber++;
            }
            else
            {
                String resultat = $"{tbNom.Text} ({cbQualite.Text})";
                int index = lbPersonne.Items.Add(resultat);

                SendMessage(lbPersonne.Handle, smEcrire, index, encodeNumber);

                Activer(true);

                encodeNumber++;
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

                lbPersonne.Items.Clear();

                string[] lignes = System.IO.File.ReadAllLines(filename);
                foreach (string ligne in lignes)
                {
                    int index = lbPersonne.Items.Add(ligne);
                    SendMessage(lbPersonne.Handle, smEcrire, index, encodeNumber);
                    encodeNumber++;
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
            int donnéeCachée = SendMessage(lbPersonne.Handle, smLire, index, 0);


            MessageBox.Show($"Données : {data}\n" +
                        $"Index : {index}\n" +
                        $"Données Cachées : {donnéeCachée}");
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

        private void EcranList_Click(object sender, EventArgs e)
        {
            lbPersonne.ClearSelected();
        }
    }
}
