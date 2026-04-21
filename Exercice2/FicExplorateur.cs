using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MainMenu
{
    public partial class FicExplorateur : Form
    {
        public FicExplorateur()
        {
            InitializeComponent();
            this.Load += new EventHandler(FicExplorateur_Load);
        }

        private void FicExplorateur_Load(object sender, EventArgs e)
        {
            lireDisques();
        }

        void lireDisques()
        {
            tvRepertoire.Nodes.Clear();
            string[] disques = Environment.GetLogicalDrives();

            foreach (string d in disques)
            {
                TreeNode noeud = new TreeNode(d);
                noeud.ImageIndex = 0;
                noeud.SelectedImageIndex = 0;
                tvRepertoire.Nodes.Add(noeud);
                LireRepertoires(d, noeud);
            }
        }

        private void LireRepertoires(string chemin, TreeNode noeudParent)
        {
            try
            {
                if (Directory.Exists(chemin))
                {
                    string[] dossiers = Directory.GetDirectories(chemin);
                    foreach (string d in dossiers)
                    {
                        DirectoryInfo info = new DirectoryInfo(d);
                        TreeNode nouveauNoeud = new TreeNode(info.Name);
                        nouveauNoeud.ImageIndex = 1;
                        nouveauNoeud.SelectedImageIndex = 1;
                        noeudParent.Nodes.Add(nouveauNoeud);
                    }
                }
            }
            catch { }
        }

        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();
            try
            {
                string[] fichiers = Directory.GetFiles(chemin);
                foreach (string f in fichiers)
                {
                    FileInfo info = new FileInfo(f);
                    ListViewItem item = new ListViewItem(info.Name, 2);
                    item.SubItems.Add(info.Length.ToString());
                    item.SubItems.Add(info.CreationTime.ToShortDateString());
                    item.SubItems.Add(info.LastWriteTime.ToShortDateString());
                    lvFichiers.Items.Add(item);
                }
            }
            catch { }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.FullPath;

            // ÉTAPE CRUCIALE : Si le dossier n'a pas encore été exploré, on le fait
            if (e.Node.Nodes.Count == 0)
            {
                LireRepertoires(chemin, e.Node);
            }

            e.Node.Expand(); // Ouvre le dossier visuellement
            LireFichiers(chemin);
            slMessage.Text = chemin;
        }

        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsaDetail_Click(object sender, EventArgs e) => lvFichiers.View = View.Details;
        private void tsaGrandesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.LargeIcon;
        private void tsaPetitesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.SmallIcon;
        private void tsaListe_Click(object sender, EventArgs e) => lvFichiers.View = View.List;

        private void lvFichiers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}