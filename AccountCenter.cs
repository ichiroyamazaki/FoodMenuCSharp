using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TPFood
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ichiro Yamazaki\Documents\Koshigaya.mdf"";Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SqlConnection connect)
        {
            this.connect = connect;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            passwordBox.Clear();

            usernameBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * From admin WHERE username = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                            cmd.Parameters.AddWithValue("@pass", passwordBox.Text);
                            Class1.uname = usernameBox.Text;
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Log in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form3 form4 = new Form3();
                                form4.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Server Error.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void passwordButton_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordButton.Checked == true)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
