namespace MainMenu
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            menuStrip1 = new MenuStrip();
            controlesToolStripMenuItem = new ToolStripMenuItem();
            MenuList = new ToolStripMenuItem();
            MenuProgBar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuExit = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            MenuEditor = new ToolStripMenuItem();
            malwareToolStripMenuItem = new ToolStripMenuItem();
            spirographeToolStripMenuItem = new ToolStripMenuItem();
            horlogeToolStripMenuItem = new ToolStripMenuItem();
            monitoringClavierSourisToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            MenuAbout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controlesToolStripMenuItem, applicationsToolStripMenuItem, aToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlesToolStripMenuItem
            // 
            controlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuList, MenuProgBar, toolStripSeparator1, MenuExit });
            controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            controlesToolStripMenuItem.Size = new Size(86, 24);
            controlesToolStripMenuItem.Text = "Controles";
            // 
            // MenuList
            // 
            MenuList.Name = "MenuList";
            MenuList.Size = new Size(229, 26);
            MenuList.Text = "Liste";
            MenuList.Click += MenuList_Click;
            // 
            // MenuProgBar
            // 
            MenuProgBar.Name = "MenuProgBar";
            MenuProgBar.Size = new Size(229, 26);
            MenuProgBar.Text = "Barre de Progression";
            MenuProgBar.Click += MenuProgBar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(226, 6);
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(229, 26);
            MenuExit.Text = "Exit (Alt + q)";
            MenuExit.Click += MenuExit_Click;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuEditor, malwareToolStripMenuItem, spirographeToolStripMenuItem, horlogeToolStripMenuItem, monitoringClavierSourisToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(106, 24);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // MenuEditor
            // 
            MenuEditor.Name = "MenuEditor";
            MenuEditor.Size = new Size(259, 26);
            MenuEditor.Text = "Editeur";
            MenuEditor.Click += MenuEditor_Click;
            // 
            // malwareToolStripMenuItem
            // 
            malwareToolStripMenuItem.Name = "malwareToolStripMenuItem";
            malwareToolStripMenuItem.Size = new Size(259, 26);
            malwareToolStripMenuItem.Text = "Malware";
            malwareToolStripMenuItem.Click += malwareToolStripMenuItem_Click;
            // 
            // spirographeToolStripMenuItem
            // 
            spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            spirographeToolStripMenuItem.Size = new Size(259, 26);
            spirographeToolStripMenuItem.Text = "Spirographe";
            spirographeToolStripMenuItem.Click += spirographeToolStripMenuItem_Click;
            // 
            // horlogeToolStripMenuItem
            // 
            horlogeToolStripMenuItem.Name = "horlogeToolStripMenuItem";
            horlogeToolStripMenuItem.Size = new Size(259, 26);
            horlogeToolStripMenuItem.Text = "Horloge";
            horlogeToolStripMenuItem.Click += horlogeToolStripMenuItem_Click;
            // 
            // monitoringClavierSourisToolStripMenuItem
            // 
            monitoringClavierSourisToolStripMenuItem.Name = "monitoringClavierSourisToolStripMenuItem";
            monitoringClavierSourisToolStripMenuItem.Size = new Size(259, 26);
            monitoringClavierSourisToolStripMenuItem.Text = "Monitoring Clavier Souris";
            monitoringClavierSourisToolStripMenuItem.Click += monitoringClavierSourisToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuAbout });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(54, 24);
            aToolStripMenuItem.Text = "Aide";
            // 
            // MenuAbout
            // 
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Size = new Size(153, 26);
            MenuAbout.Text = "A propos";
            MenuAbout.Click += MenuAbout_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Menu Principal - Vainerac Hub";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem controlesToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem MenuList;
        private ToolStripMenuItem MenuProgBar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuExit;
        private ToolStripMenuItem MenuEditor;
        private ToolStripMenuItem MenuAbout;
        private ToolStripMenuItem malwareToolStripMenuItem;
        private ToolStripMenuItem spirographeToolStripMenuItem;
        private ToolStripMenuItem horlogeToolStripMenuItem;
        private ToolStripMenuItem monitoringClavierSourisToolStripMenuItem;
    }
}
