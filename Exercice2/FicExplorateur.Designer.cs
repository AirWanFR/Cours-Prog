namespace MainMenu
{
    partial class FicExplorateur
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicExplorateur));
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tvRepertoire = new TreeView();
            ilSmall = new ImageList(components);
            lvFichiers = new ListView();
            NOM = new ColumnHeader();
            TAIL = new ColumnHeader();
            CREA = new ColumnHeader();
            MODI = new ColumnHeader();
            ilLarge = new ImageList(components);
            tsCommandes = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsddbApparence = new ToolStripDropDownButton();
            tsaPetitesIcones = new ToolStripMenuItem();
            tsaGrandesIcones = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tsCommandes.SuspendLayout();
            SuspendLayout();
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(20, 20);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 424);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 26);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(77, 20);
            slMessage.Text = "Bienvenue";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvRepertoire);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvFichiers);
            splitContainer1.Size = new Size(800, 397);
            splitContainer1.SplitterDistance = 265;
            splitContainer1.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.ImageIndex = 0;
            tvRepertoire.ImageList = ilSmall;
            tvRepertoire.Location = new Point(2, 3);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.SelectedImageIndex = 0;
            tvRepertoire.Size = new Size(260, 391);
            tvRepertoire.TabIndex = 3;
            tvRepertoire.AfterSelect += tvRepertoire_AfterSelect;
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth32Bit;
            ilSmall.ImageStream = (ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = Color.Transparent;
            ilSmall.Images.SetKeyName(0, "16hdd.ico");
            ilSmall.Images.SetKeyName(1, "16f.ico");
            ilSmall.Images.SetKeyName(2, "16file.ico");
            // 
            // lvFichiers
            // 
            lvFichiers.Columns.AddRange(new ColumnHeader[] { NOM, TAIL, CREA, MODI });
            lvFichiers.LargeImageList = ilLarge;
            lvFichiers.Location = new Point(3, 3);
            lvFichiers.Name = "lvFichiers";
            lvFichiers.Size = new Size(515, 391);
            lvFichiers.SmallImageList = ilSmall;
            lvFichiers.TabIndex = 3;
            lvFichiers.UseCompatibleStateImageBehavior = false;
            lvFichiers.View = View.Details;
            lvFichiers.SelectedIndexChanged += lvFichiers_SelectedIndexChanged;
            // 
            // NOM
            // 
            NOM.Text = "Nom";
            NOM.Width = 200;
            // 
            // TAIL
            // 
            TAIL.Text = "Taille";
            TAIL.Width = 100;
            // 
            // CREA
            // 
            CREA.Text = "Création";
            CREA.Width = 100;
            // 
            // MODI
            // 
            MODI.Text = "Modification";
            MODI.Width = 100;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = ColorDepth.Depth32Bit;
            ilLarge.ImageStream = (ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = Color.Transparent;
            ilLarge.Images.SetKeyName(0, "32hdd.ico");
            ilLarge.Images.SetKeyName(1, "32f.ico");
            ilLarge.Images.SetKeyName(2, "32file.ico");
            // 
            // tsCommandes
            // 
            tsCommandes.ImageScalingSize = new Size(20, 20);
            tsCommandes.Items.AddRange(new ToolStripItem[] { tsbQuitter, toolStripSeparator1, tsddbApparence });
            tsCommandes.Location = new Point(0, 0);
            tsCommandes.Name = "tsCommandes";
            tsCommandes.Size = new Size(800, 27);
            tsCommandes.TabIndex = 0;
            tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = (Image)resources.GetObject("tsbQuitter.Image");
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(29, 24);
            tsbQuitter.Text = "tsbQuitter";
            tsbQuitter.Click += tsbQuitter_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsddbApparence
            // 
            tsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetitesIcones, tsaGrandesIcones, tsaListe, tsaDetail });
            tsddbApparence.Image = (Image)resources.GetObject("tsddbApparence.Image");
            tsddbApparence.ImageTransparentColor = Color.Magenta;
            tsddbApparence.Name = "tsddbApparence";
            tsddbApparence.Size = new Size(34, 24);
            tsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetitesIcones
            // 
            tsaPetitesIcones.Name = "tsaPetitesIcones";
            tsaPetitesIcones.Size = new Size(224, 26);
            tsaPetitesIcones.Text = "Petites Icones";
            tsaPetitesIcones.Click += tsaPetitesIcones_Click;
            // 
            // tsaGrandesIcones
            // 
            tsaGrandesIcones.Name = "tsaGrandesIcones";
            tsaGrandesIcones.Size = new Size(224, 26);
            tsaGrandesIcones.Text = "Grande Icône";
            tsaGrandesIcones.Click += tsaGrandesIcones_Click;
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(224, 26);
            tsaListe.Text = "Liste";
            tsaListe.Click += tsaListe_Click;
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(224, 26);
            tsaDetail.Text = "Detail";
            tsaDetail.Click += tsaDetail_Click;
            // 
            // FicExplorateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(ssMessage);
            Controls.Add(tsCommandes);
            Name = "FicExplorateur";
            Text = "FicExplorateur";
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tsCommandes.ResumeLayout(false);
            tsCommandes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbQuitter;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slMessage;
        private StatusStrip ssMessage;
        private TreeView tvRepertoire;
        private ListView lvFichiers;
        private ColumnHeader NOM;
        private ColumnHeader TAIL;
        private ColumnHeader CREA;
        private ColumnHeader MODI;
        private ToolStrip tsCommandes;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbApparence;
        private ToolStripMenuItem tsaPetitesIcones;
        private ToolStripMenuItem tsaGrandesIcones;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private ImageList ilSmall;
        private ImageList ilLarge;
    }
}