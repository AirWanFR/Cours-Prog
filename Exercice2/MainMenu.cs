namespace MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void FoncNonImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction Non implémentée, merci de patienter.", "Error 501 - Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Closing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuEditor_Click(object sender, EventArgs e)
        {
            FoncNonImplemented(sender, e);
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Closing(sender, e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Alt)
            {
                Closing(sender, e);
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            Apropos Wapp = new Apropos();
            Wapp.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuProgBar_Click(object sender, EventArgs e)
        {
            ProgressBar Wpb = new ProgressBar();
            Wpb.ShowDialog();
        }

        private void MenuList_Click(object sender, EventArgs e)
        {
            EcranList Wel = new EcranList();
            Wel.ShowDialog();
        }
    }
}
