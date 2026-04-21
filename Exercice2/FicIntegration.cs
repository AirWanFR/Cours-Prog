using System;
using System.Drawing;
using System.Windows.Forms;

public delegate double fctAIntegrer(double x);

namespace MainMenu
{
    public partial class FicIntegration : Form
    {
        public FicIntegration()
        {
            InitializeComponent();
        }

        // --- Fonctions mathématiques à intégrer ---

        // Bouton bPolynome (Méthode traditionnelle)
        private void bPolynome_Click(object sender, EventArgs e)
        {
            try
            {
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
                lbResultats.Items.Add("Polynôme: x² + 2");

                for (int i = 0; i <= 4; i++)
                {
                    int n = nBase * (int)Math.Pow(2, i);
                    double h = (droite - gauche) / n;
                    double aire = 0;

                    for (int j = 0; j < n; j++)
                    {
                        double xA = gauche + (j * h);
                        double xB = xA + h;
                        // Calcul du polynôme x² + 2 écrit en dur ici
                        double fA = (xA * xA) + 2;
                        double fB = (xB * xB) + 2;
                        aire += (fA + fB) * h / 2;
                    }
                    lbResultats.Items.Add($"Nb Int: {n} => {aire}");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Bouton bTrigonometrique (Méthode traditionnelle)
        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            try
            {
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
                lbResultats.Items.Add("Trigonométrique: sin(x)");

                for (int i = 0; i <= 4; i++)
                {
                    int n = nBase * (int)Math.Pow(2, i);
                    double h = (droite - gauche) / n;
                    double aire = 0;

                    for (int j = 0; j < n; j++)
                    {
                        double xA = gauche + (j * h);
                        double xB = xA + h;
                        // Calcul du sinus écrit en dur ici
                        aire += (Math.Sin(xA) + Math.Sin(xB)) * h / 2;
                    }
                    lbResultats.Items.Add($"Nb Int: {n} => {aire}");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // La fonction polynôme demandée : x² + 2
        private double MonPolynome(double x)
        {
            return (x * x) + 2;
        }

        // --- Méthode générique de calcul (Méthode des trapèzes) ---

        // Cette méthode est "généralisée" grâce au paramètre delegate 'f'
        double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroite, int nInterval)
        {
            // h est la largeur d'un petit intervalle
            double h = (xDroite - xGauche) / nInterval;
            double sommeAire = 0;

            for (int i = 0; i < nInterval; i++)
            {
                double a = xGauche + (i * h);
                double b = a + h;

                // Formule de l'aire d'un trapèze : (f(a) + f(b)) * h / 2
                sommeAire += (f(a) + f(b)) * h / 2;
            }
            return sommeAire;
        }

        // --- Gestion des clics boutons ---

        // Calcul du polynôme via le pointeur de fonction (bPointeurPolynome)
        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            CalculerEtAfficher(MonPolynome, "Polynôme: x² + 2");
        }

        // Calcul trigonométrique via le pointeur de fonction (bPointeurTrigonometrique)
        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            // On passe la fonction standard Math.Sin comme argument
            CalculerEtAfficher(Math.Sin, "Trigonométrique: sin(x)");
        }

        // --- Méthode de traitement commune ---

        private void CalculerEtAfficher(fctAIntegrer fonction, string titre)
        {
            try
            {
                // Récupération des valeurs depuis les TextBox
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                if (nBase < 1) nBase = 1; // Sécurité : au moins 1 intervalle

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes");
                lbResultats.Items.Add(titre);

                // Boucle de division de l'intervalle (n, 2n, 4n, 8n, 16n)
                for (int i = 0; i <= 4; i++)
                {
                    int nActuel = nBase * (int)Math.Pow(2, i);
                    double resultat = IntegrationTrapeze(fonction, gauche, droite, nActuel);

                    lbResultats.Items.Add($"Nb Int: {nActuel} => {resultat}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez vérifier vos saisies : " + ex.Message);
            }
        }
    }
}