namespace MainMenu
{
    partial class FicEditeur
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
            PictureBox pbEnregistrer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicEditeur));
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            bNouveau = new ToolStripMenuItem();
            bOuvrir = new ToolStripMenuItem();
            bEnregistrer = new ToolStripMenuItem();
            bQuitter = new ToolStripMenuItem();
            editerToolStripMenuItem = new ToolStripMenuItem();
            bCopier = new ToolStripMenuItem();
            bCouper = new ToolStripMenuItem();
            bColler = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            bJusGauche = new ToolStripMenuItem();
            bJusDroite = new ToolStripMenuItem();
            bJusCentre = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem1 = new ToolStripMenuItem();
            bCarGras = new ToolStripMenuItem();
            bCarItalique = new ToolStripMenuItem();
            bCarSouligne = new ToolStripMenuItem();
            bCarBarre = new ToolStripMenuItem();
            pMenu = new Panel();
            rtbText = new RichTextBox();
            pbQuitter = new PictureBox();
            pbNouveau = new PictureBox();
            pbOuvrir = new PictureBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            pbEnregistrer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            SuspendLayout();
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.Image = (Image)resources.GetObject("pbEnregistrer.Image");
            pbEnregistrer.Location = new Point(80, 34);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(30, 29);
            pbEnregistrer.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnregistrer.TabIndex = 4;
            pbEnregistrer.TabStop = false;
            pbEnregistrer.Click += pbEnregistrer_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editerToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(403, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bNouveau, bOuvrir, bEnregistrer, bQuitter });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // bNouveau
            // 
            bNouveau.Name = "bNouveau";
            bNouveau.Size = new Size(163, 26);
            bNouveau.Text = "Nouveau";
            bNouveau.Click += bNouveau_Click;
            // 
            // bOuvrir
            // 
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(163, 26);
            bOuvrir.Text = "Ouvrir";
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(163, 26);
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bQuitter
            // 
            bQuitter.Name = "bQuitter";
            bQuitter.Size = new Size(163, 26);
            bQuitter.Text = "Quitter";
            bQuitter.Click += bQuitter_Click;
            // 
            // editerToolStripMenuItem
            // 
            editerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bCopier, bCouper, bColler });
            editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            editerToolStripMenuItem.Size = new Size(62, 24);
            editerToolStripMenuItem.Text = "Editer";
            // 
            // bCopier
            // 
            bCopier.Name = "bCopier";
            bCopier.Size = new Size(224, 26);
            bCopier.Text = "Copier ";
            bCopier.Click += bCopier_Click;
            // 
            // bCouper
            // 
            bCouper.Name = "bCouper";
            bCouper.Size = new Size(224, 26);
            bCouper.Text = "Couper";
            bCouper.Click += bCouper_Click;
            // 
            // bColler
            // 
            bColler.Name = "bColler";
            bColler.Size = new Size(224, 26);
            bColler.Text = "Coller";
            bColler.Click += bColler_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, formatToolStripMenuItem1 });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bJusGauche, bJusDroite, bJusCentre });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(155, 26);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // bJusGauche
            // 
            bJusGauche.Name = "bJusGauche";
            bJusGauche.Size = new Size(141, 26);
            bJusGauche.Text = "Gauche";
            bJusGauche.Click += bJusGauche_Click;
            // 
            // bJusDroite
            // 
            bJusDroite.Name = "bJusDroite";
            bJusDroite.Size = new Size(141, 26);
            bJusDroite.Text = "Droite";
            bJusDroite.Click += bJusDroite_Click;
            // 
            // bJusCentre
            // 
            bJusCentre.Name = "bJusCentre";
            bJusCentre.Size = new Size(141, 26);
            bJusCentre.Text = "Centre";
            bJusCentre.Click += bJusCentre_Click;
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(155, 26);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += policeToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem1
            // 
            formatToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { bCarGras, bCarItalique, bCarSouligne, bCarBarre });
            formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            formatToolStripMenuItem1.Size = new Size(155, 26);
            formatToolStripMenuItem1.Text = "Caractère";
            // 
            // bCarGras
            // 
            bCarGras.Name = "bCarGras";
            bCarGras.Size = new Size(150, 26);
            bCarGras.Text = "Gras";
            bCarGras.Click += bCarGras_Click;
            // 
            // bCarItalique
            // 
            bCarItalique.Name = "bCarItalique";
            bCarItalique.Size = new Size(150, 26);
            bCarItalique.Text = "Italique";
            bCarItalique.Click += bCarItalique_Click;
            // 
            // bCarSouligne
            // 
            bCarSouligne.Name = "bCarSouligne";
            bCarSouligne.Size = new Size(150, 26);
            bCarSouligne.Text = "Souligné";
            bCarSouligne.Click += bCarSouligne_Click;
            // 
            // bCarBarre
            // 
            bCarBarre.Name = "bCarBarre";
            bCarBarre.Size = new Size(150, 26);
            bCarBarre.Text = "Barré";
            bCarBarre.Click += bCarBarre_Click;
            // 
            // pMenu
            // 
            pMenu.Controls.Add(rtbText);
            pMenu.Location = new Point(12, 66);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(357, 247);
            pMenu.TabIndex = 1;
            // 
            // rtbText
            // 
            rtbText.Dock = DockStyle.Fill;
            rtbText.Location = new Point(0, 0);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(357, 247);
            rtbText.TabIndex = 6;
            rtbText.Text = "";
            rtbText.TextChanged += rtbText_TextChanged;
            // 
            // pbQuitter
            // 
            pbQuitter.Image = (Image)resources.GetObject("pbQuitter.Image");
            pbQuitter.Location = new Point(334, 34);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(35, 29);
            pbQuitter.SizeMode = PictureBoxSizeMode.Zoom;
            pbQuitter.TabIndex = 5;
            pbQuitter.TabStop = false;
            pbQuitter.Click += pbQuitter_Click;
            // 
            // pbNouveau
            // 
            pbNouveau.Image = (Image)resources.GetObject("pbNouveau.Image");
            pbNouveau.Location = new Point(15, 34);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(25, 29);
            pbNouveau.SizeMode = PictureBoxSizeMode.Zoom;
            pbNouveau.TabIndex = 2;
            pbNouveau.TabStop = false;
            pbNouveau.Click += pbNouveau_Click;
            // 
            // pbOuvrir
            // 
            pbOuvrir.Image = (Image)resources.GetObject("pbOuvrir.Image");
            pbOuvrir.Location = new Point(46, 34);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(28, 29);
            pbOuvrir.SizeMode = PictureBoxSizeMode.Zoom;
            pbOuvrir.TabIndex = 3;
            pbOuvrir.TabStop = false;
            pbOuvrir.Click += pbOuvrir_Click;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // FicEditeur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 352);
            Controls.Add(pMenu);
            Controls.Add(pbQuitter);
            Controls.Add(pbNouveau);
            Controls.Add(pbOuvrir);
            Controls.Add(menuStrip1);
            Controls.Add(pbEnregistrer);
            MainMenuStrip = menuStrip1;
            Name = "FicEditeur";
            Text = "FicEditeur";
            Load += FicEditeur_Load;
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem bNouveau;
        private ToolStripMenuItem bOuvrir;
        private ToolStripMenuItem bEnregistrer;
        private ToolStripMenuItem bQuitter;
        private ToolStripMenuItem editerToolStripMenuItem;
        private ToolStripMenuItem bCopier;
        private ToolStripMenuItem bCouper;
        private ToolStripMenuItem bColler;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem1;
        private ToolStripMenuItem bJusGauche;
        private ToolStripMenuItem bJusDroite;
        private ToolStripMenuItem bJusCentre;
        private ToolStripMenuItem bCarGras;
        private ToolStripMenuItem bCarItalique;
        private ToolStripMenuItem bCarSouligne;
        private ToolStripMenuItem bCarBarre;
        private Panel pMenu;
        private PictureBox pbNouveau;
        private PictureBox pbOuvrir;
        private PictureBox pbEnregistrer;
        private PictureBox pbQuitter;
        private RichTextBox rtbText;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private FontDialog fdPolice;
    }
}