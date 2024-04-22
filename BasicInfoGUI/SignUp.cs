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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GeneralLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelCity_Click(object sender, EventArgs e)
        {

        }

        private void labelAlreadyHaveAnID_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private bool EmailExists(SqlConnection conn, string email)
        {
            string query = "SELECT COUNT(*) FROM userInfo WHERE email = @Email;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool PhoneNumberExists(SqlConnection conn, string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM userInfo WHERE phoneNumber = @PhoneNumber;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                //1. Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=CrudOperation;Integrated Security=True;";

                //2. Establish Connection.
                SqlConnection conn = new SqlConnection(connection);

                //3. Open Connection.
                conn.Open();

                //4. Duplicate Email/Number checking.
                string email = textBoxEmail.Text;
                string number = textBoxPhoneNumber.Text;
                if (EmailExists(conn, email))
                {
                    MessageBox.Show("Email already exists.");
                    return;
                }

                if (PhoneNumberExists(conn, number))
                {
                    MessageBox.Show("Phone number already exists.");
                    return;
                }

                //5. Prepare Query.
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                string password = textBoxPassword.Text;
                DateTime dateTime = DateOfBirth.Value;

                string query = "INSERT INTO userInfo (firstName, lastName, phoneNumber, email, password, dateOfBirth) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Password, @DateOfBirth);";

                // 6. Execute Query with parameters
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", number);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTime);
                cmd.ExecuteNonQuery();

                //7. Close Connection.
                conn.Close();

                MessageBox.Show("Congratulations, your account has been successfully created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
