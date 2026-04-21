using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();


        }

        private async void exec_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            this.Cursor = Cursors.WaitCursor;
            exec.Enabled = false;

            progressBar1.Value = 0;
            progressBar2.Value = 0;

            int nbFichiers = random.Next(5, 30);
            progressBar1.Maximum = nbFichiers;

            for (int i = 0; i < nbFichiers; i++)
            {
                progressBar2.Value = 0;
                int tailleFichier = random.Next(50, 101);
                progressBar2.Maximum = tailleFichier;

                while (progressBar2.Value < progressBar2.Maximum)
                {
                    int progression = random.Next(1, 10);

                    if (progressBar2.Value + progression <= progressBar2.Maximum)
                        progressBar2.Value += progression;
                    else
                        progressBar2.Value = progressBar2.Maximum;

                    progressBar2.Refresh();
                    await Task.Delay(random.Next(20, 100));
                }

                progressBar1.Value++;
                progressBar1.Refresh();
            }

            this.Cursor = Cursors.Default;
            exec.Enabled = true;

            MessageBox.Show("Simulation terminée.");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
