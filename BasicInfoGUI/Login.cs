using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicInfoGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void GeneralLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxCredentials.Text == "admin" && textBoxPassword.Text == "admin")
                {
                    new AdminDashboard().Show();
                    this.Hide();
                }
                else
                {
                    //1. Address of SQL Server and Database.
                    string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=CrudOperation;Integrated Security=True;";

                    //2. Establish Connection.
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        //3. Open Connection.
                        conn.Open();

                        //4. Prepare Query.
                        string cred = textBoxCredentials.Text;
                        string password = textBoxPassword.Text;

                        string query = "SELECT COUNT(*) FROM userInfo WHERE (email = @Email OR phoneNumber = @Number) AND password = @Password;";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", cred);
                            cmd.Parameters.AddWithValue("@Number", cred);
                            cmd.Parameters.AddWithValue("@Password", password);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                new LoginDashboard().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect email or password. Please try again.");
                            }
                        }

                        //5. Close Connection.
                        conn.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
