using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class FicSpirographe : Form
    {
        private Color cFond;
        private Color cTrait;
        private GraphicsPath gpSauvegarde;
        public FicSpirographe()
        {
            InitializeComponent();

            cFond = Color.White;
            cTrait = Color.Blue;
            gpSauvegarde = null;
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value;
            int iDensite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            int xOffset = 248;
            int largeurUtile = ClientSize.Width - xOffset;
            int hauteurUtile = ClientSize.Height;

            int xc = xOffset + (largeurUtile / 2);
            int yc = hauteurUtile / 2;
            int rayon = (Math.Min(largeurUtile, hauteurUtile) / 2) - 10;

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            gpSauvegarde = new GraphicsPath();

            double seuilArrêt = (double)rayon * iProfondeur / 100.0;

            while (Math.Sqrt(Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2)) > seuilArrêt)
            {
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine((float)sx[i], (float)sy[i], (float)sx[i + 1], (float)sy[i + 1]);
                }

                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }

            this.Invalidate();
        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate();
            }

        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (gpSauvegarde != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(cFond),
                    new Rectangle(new Point(248, 0), ClientSize));

                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }
    }
}
