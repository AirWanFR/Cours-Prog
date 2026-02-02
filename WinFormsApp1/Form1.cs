using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmp = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 wind2 = new Form2();
            wind2.Show();
            this.Hide();
        }
    }
}
