namespace Exercice2
{
    partial class EcranList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranList));
            bEnregistrer = new Button();
            bAjouter = new Button();
            bSupprimer = new Button();
            lFichier = new Label();
            lNom = new Label();
            lQualite = new Label();
            bConfirmer = new Button();
            bAnnuler = new Button();
            cbQualite = new ComboBox();
            lbPersonne = new ListBox();
            bOuvrir = new Button();
            gbDetail = new GroupBox();
            tbNom = new TextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            bModifier = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(39, 238);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(94, 29);
            bEnregistrer.TabIndex = 1;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(39, 290);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 2;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(39, 325);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(94, 29);
            bSupprimer.TabIndex = 3;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(39, 33);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(108, 20);
            lFichier.TabIndex = 4;
            lFichier.Text = "Nom de fichier";
            lFichier.Click += label1_Click;
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(6, 93);
            lNom.Name = "lNom";
            lNom.Size = new Size(42, 20);
            lNom.TabIndex = 5;
            lNom.Text = "Nom";
            // 
            // lQualite
            // 
            lQualite.AutoSize = true;
            lQualite.Location = new Point(6, 32);
            lQualite.Name = "lQualite";
            lQualite.Size = new Size(57, 20);
            lQualite.TabIndex = 6;
            lQualite.Text = "Qualité";
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(6, 148);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(94, 29);
            bConfirmer.TabIndex = 7;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(106, 148);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(94, 29);
            bAnnuler.TabIndex = 8;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Items.AddRange(new object[] { "Madame", "Mademoiselle", "Monsieur", "Mondamoiseau", "Indéfini" });
            cbQualite.Location = new Point(6, 55);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(151, 28);
            cbQualite.TabIndex = 9;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.Location = new Point(39, 56);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(391, 144);
            lbPersonne.TabIndex = 10;
            lbPersonne.DoubleClick += lbPersonne_DoubleClick;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(39, 206);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(94, 29);
            bOuvrir.TabIndex = 11;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(cbQualite);
            gbDetail.Controls.Add(lQualite);
            gbDetail.Controls.Add(lNom);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Location = new Point(180, 206);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(268, 183);
            gbDetail.TabIndex = 12;
            gbDetail.TabStop = false;
            gbDetail.Text = "Détail personne";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(6, 115);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(151, 27);
            tbNom.TabIndex = 10;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "ofdOuvrir";
            // 
            // sfdEnregistrer
            // 
            sfdEnregistrer.FileName = "personnes.txt";
            // 
            // bModifier
            // 
            bModifier.Location = new Point(39, 360);
            bModifier.Name = "bModifier";
            bModifier.Size = new Size(94, 29);
            bModifier.TabIndex = 13;
            bModifier.Text = "Modifier";
            bModifier.UseVisualStyleBackColor = false;
            bModifier.Click += bModifier_Click;
            // 
            // EcranList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 415);
            Controls.Add(bModifier);
            Controls.Add(gbDetail);
            Controls.Add(bOuvrir);
            Controls.Add(lbPersonne);
            Controls.Add(lFichier);
            Controls.Add(bSupprimer);
            Controls.Add(bAjouter);
            Controls.Add(bEnregistrer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EcranList";
            Text = "EcranList";
            Load += EcranList_Load;
            Click += EcranList_Click;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bEnregistrer;
        private Button bAjouter;
        private Button bSupprimer;
        private Label lFichier;
        private Label lNom;
        private Label lQualite;
        private Button bConfirmer;
        private Button bAnnuler;
        private ComboBox cbQualite;
        private ListBox lbPersonne;
        private Button bOuvrir;
        private GroupBox gbDetail;
        private TextBox tbNom;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private Button bModifier;
    }
}