namespace WinFormsApp1
{
    public partial class Form1_edit : Form
    {
        public Form1_edit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmp = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = tmp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();
            this.Hide();
        }
    }
}
