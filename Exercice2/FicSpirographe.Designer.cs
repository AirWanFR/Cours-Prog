namespace MainMenu
{
    partial class FicSpirographe
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
            gbParametrage = new GroupBox();
            bFond = new Button();
            bTrait = new Button();
            bGo = new Button();
            tbProfondeur = new TrackBar();
            tbDensite = new TrackBar();
            tbSommets = new TrackBar();
            lProfondeur = new Label();
            lDensite = new Label();
            lSommets = new Label();
            cdCouleur = new ColorDialog();
            gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            SuspendLayout();
            // 
            // gbParametrage
            // 
            gbParametrage.Controls.Add(bFond);
            gbParametrage.Controls.Add(bTrait);
            gbParametrage.Controls.Add(bGo);
            gbParametrage.Controls.Add(tbProfondeur);
            gbParametrage.Controls.Add(tbDensite);
            gbParametrage.Controls.Add(tbSommets);
            gbParametrage.Controls.Add(lProfondeur);
            gbParametrage.Controls.Add(lDensite);
            gbParametrage.Controls.Add(lSommets);
            gbParametrage.Location = new Point(3, 25);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Size = new Size(250, 378);
            gbParametrage.TabIndex = 0;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "Paramètrage";
            // 
            // bFond
            // 
            bFond.Location = new Point(150, 325);
            bFond.Name = "bFond";
            bFond.Size = new Size(94, 29);
            bFond.TabIndex = 7;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // bTrait
            // 
            bTrait.Location = new Point(6, 325);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(94, 29);
            bTrait.TabIndex = 1;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bGo
            // 
            bGo.Location = new Point(67, 272);
            bGo.Name = "bGo";
            bGo.Size = new Size(94, 29);
            bGo.TabIndex = 6;
            bGo.Text = "G O !";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(6, 210);
            tbProfondeur.Maximum = 80;
            tbProfondeur.Minimum = 20;
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(207, 56);
            tbProfondeur.TabIndex = 5;
            tbProfondeur.Value = 20;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(6, 128);
            tbDensite.Maximum = 20;
            tbDensite.Minimum = 5;
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(207, 56);
            tbDensite.TabIndex = 4;
            tbDensite.Value = 5;
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(6, 46);
            tbSommets.Maximum = 8;
            tbSommets.Minimum = 3;
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(207, 56);
            tbSommets.TabIndex = 3;
            tbSommets.Value = 3;
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(6, 187);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(209, 20);
            lProfondeur.TabIndex = 2;
            lProfondeur.Text = "Profondeur du dessin (20 - 80)";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(6, 105);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(177, 20);
            lDensite.TabIndex = 1;
            lDensite.Text = "Densité du dessin (5 - 20)";
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(6, 23);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(193, 20);
            lSommets.TabIndex = 0;
            lSommets.Text = "Nombre de sommets (3 - 8)";
            // 
            // FicSpirographe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbParametrage);
            Name = "FicSpirographe";
            Text = "FicSpirographe";
            gbParametrage.ResumeLayout(false);
            gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametrage;
        private Label lSommets;
        private TrackBar tbDensite;
        private TrackBar tbSommets;
        private Label lProfondeur;
        private Label lDensite;
        private TrackBar tbProfondeur;
        private Button bGo;
        private Button bFond;
        private Button bTrait;
        private ColorDialog cdCouleur;
    }
}