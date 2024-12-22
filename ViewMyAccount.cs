using System;
using System.Windows.Forms;

namespace TPFood
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            nameLoginBox.Text = Class1.uname;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
