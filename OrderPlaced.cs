using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPFood
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void labelList_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public static class SharedData
    {
        public static List<string> SelectedItems { get; set; } = new List<string>();
    }
}
