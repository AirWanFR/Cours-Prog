namespace MainMenu
{
    partial class FicBDDirect
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
            this.lbConsole = new ListBox();
            this.bConsulter = new Button();
            bDenombrer = new Button();
            bAjouter = new Button();
            lPrenom = new Label();
            lNom = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new Point(12, 12);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new Size(209, 324);
            this.lbConsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            this.bConsulter.Location = new Point(271, 12);
            this.bConsulter.Name = "bConsulter";
            this.bConsulter.Size = new Size(125, 29);
            this.bConsulter.TabIndex = 1;
            this.bConsulter.Text = "Consulter";
            this.bConsulter.UseVisualStyleBackColor = true;
            // 
            // bDenombrer
            // 
            bDenombrer.Location = new Point(271, 96);
            bDenombrer.Name = "bDenombrer";
            bDenombrer.Size = new Size(125, 29);
            bDenombrer.TabIndex = 2;
            bDenombrer.Text = "Denombrer";
            bDenombrer.UseVisualStyleBackColor = true;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(271, 295);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(125, 29);
            bAjouter.TabIndex = 3;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(271, 166);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(60, 20);
            lPrenom.TabIndex = 4;
            lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(271, 219);
            lNom.Name = "lNom";
            lNom.Size = new Size(42, 20);
            lNom.TabIndex = 5;
            lNom.Text = "Nom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // FicBDDirect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 348);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lNom);
            Controls.Add(lPrenom);
            Controls.Add(bAjouter);
            Controls.Add(bDenombrer);
            Controls.Add(this.bConsulter);
            Controls.Add(this.lbConsole);
            Name = "FicBDDirect";
            Text = "FicBDDirect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbConsole;
        private Button bConsulter;
        private Button bDenombrer;
        private Button bAjouter;
        private Label lPrenom;
        private Label lNom;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}