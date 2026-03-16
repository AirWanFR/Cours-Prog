namespace MainMenu
{
    partial class FicClavierSouris
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
            pnlSouris = new Panel();
            lblClavier = new Label();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.BorderStyle = BorderStyle.FixedSingle;
            pnlSouris.Location = new Point(348, 90);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(418, 251);
            pnlSouris.TabIndex = 0;
            pnlSouris.Paint += pnlSouris_Paint;
            pnlSouris.MouseClick += pnlSouris_MouseClick;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(79, 25);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(138, 20);
            lblClavier.TabIndex = 1;
            lblClavier.Text = "Interception Clavier";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(351, 25);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(86, 20);
            lblClicGauche.TabIndex = 0;
            lblClicGauche.Text = "Clic Gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(457, 28);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(71, 20);
            lblClicDroit.TabIndex = 2;
            lblClicDroit.Text = "Clic Droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(563, 28);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 3;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(669, 28);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(73, 20);
            lblPositionY.TabIndex = 4;
            lblPositionY.Text = "Position Y";
            // 
            // lsbClavier
            // 
            lsbClavier.Enabled = false;
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(12, 48);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(253, 264);
            lsbClavier.TabIndex = 5;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(12, 318);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(253, 29);
            butRAZ.TabIndex = 6;
            butRAZ.Text = "Remise à Zéro";
            butRAZ.UseVisualStyleBackColor = true;
            butRAZ.Click += butRAZ_Click;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Enabled = false;
            tbxClicGauche.Location = new Point(351, 57);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.PlaceholderText = "0";
            tbxClicGauche.ReadOnly = true;
            tbxClicGauche.Size = new Size(100, 27);
            tbxClicGauche.TabIndex = 7;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Enabled = false;
            tbxClicDroit.Location = new Point(457, 57);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.PlaceholderText = "0";
            tbxClicDroit.ReadOnly = true;
            tbxClicDroit.Size = new Size(100, 27);
            tbxClicDroit.TabIndex = 8;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Enabled = false;
            tbxPositionX.Location = new Point(563, 57);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.PlaceholderText = "0";
            tbxPositionX.ReadOnly = true;
            tbxPositionX.Size = new Size(100, 27);
            tbxPositionX.TabIndex = 9;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Enabled = false;
            tbxPositionY.Location = new Point(669, 57);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.PlaceholderText = "0";
            tbxPositionY.ReadOnly = true;
            tbxPositionY.Size = new Size(100, 27);
            tbxPositionY.TabIndex = 10;
            // 
            // FicClavierSouris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 382);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(lblPositionX);
            Controls.Add(lblPositionY);
            Controls.Add(lblClicGauche);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClavier);
            Controls.Add(pnlSouris);
            KeyPreview = true;
            Name = "FicClavierSouris";
            Text = "Espionnage du clavier et de la souris";
            KeyDown += FicClavierSouris_KeyDown;
            KeyPress += FicClavierSouris_KeyPress;
            KeyUp += FicClavierSouris_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private Label lblClavier;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
    }
}