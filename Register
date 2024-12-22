using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TPFood
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ichiro Yamazaki\Documents\Koshigaya.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void passwordButton_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (passwordButton.Checked == true)
                {
                    signup_password.UseSystemPasswordChar = false;
                }
                else
                {
                    signup_password.UseSystemPasswordChar = true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
                if (signup_username.Text == "" || signup_password.Text == "")
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
                        String checkUsername = "SELECT * FROM admin WHERE username = '" + signup_username.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (username, password, date_created) " +
                                    "VALUES(@username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 form1 = new Form1();
                                    form1.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    { connect.Close(); }
                }
                
            }
        }
        


        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
