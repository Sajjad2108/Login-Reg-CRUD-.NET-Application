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
    public partial class UpdateDelete : Form
    {
        string searchValue;
        public UpdateDelete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=CrudOperation;Integrated Security=True;";

                // Establish Connection.
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();

                    // Prepare Query.
                    searchValue = textBoxInfoSearch.Text;

                    string query = @" SELECT * FROM userInfo WHERE userID = @SearchValue OR email = @SearchEmail OR phoneNumber = @SearchValue";

                    // Execute Query.
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", searchValue);
                        cmd.Parameters.AddWithValue("@SearchEmail", searchValue);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxFirstNameUpdate.Text = reader["firstName"].ToString();
                                textBoxLastNameUpdate.Text = reader["lastName"].ToString();
                                textBoxPhoneNumberUpdate.Text = reader["phoneNumber"].ToString();
                                textBoxEmailUpdate.Text = reader["email"].ToString();
                                textBoxPasswordUpdate.Text = reader["password"].ToString();
                                DateOfBirth.Value = (DateTime)reader["dateOfBirth"];
                            }
                            else
                            {
                                MessageBox.Show("No record found for the given search value.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonOkay_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void buttonUpdateCon_Click(object sender, EventArgs e)
        {
            try
            {
                // Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=CrudOperation;Integrated Security=True;";

                // Establish Connection.
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();

                    // Prepare Query.
                    string firsNameUp = textBoxFirstNameUpdate.Text;
                    string lastNameUp = textBoxLastNameUpdate.Text;
                    string numberUp = textBoxPhoneNumberUpdate.Text;
                    string emailUp = textBoxEmailUpdate.Text;
                    string passUp = textBoxPasswordUpdate.Text;
                    DateTime dateTimeUp = DateOfBirth.Value;

                    // Build the query string.
                    string query = @"UPDATE userInfo SET firstName = @FirstName, lastName = @LastName, phoneNumber = @PhoneNumber, email = @Email, password = @Password, dateOfBirth = @DateOfBirth WHERE userID = @SearchValue OR email = @SearchValue OR phoneNumber = @SearchValue;";

                    // Execute Query.
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firsNameUp);
                        cmd.Parameters.AddWithValue("@LastName", lastNameUp);
                        cmd.Parameters.AddWithValue("@PhoneNumber", numberUp);
                        cmd.Parameters.AddWithValue("@Email", emailUp);
                        cmd.Parameters.AddWithValue("@Password", passUp);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimeUp);
                        cmd.Parameters.AddWithValue("@SearchValue", textBoxInfoSearch.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record updated. Verify the ID.");
                        }
                    }

                    // Close Connection.
                    conn.Close();

                    // Clear text boxes.
                    textBoxFirstNameUpdate.Text = "";
                    textBoxLastNameUpdate.Text = "";
                    textBoxPhoneNumberUpdate.Text = "";
                    textBoxEmailUpdate.Text = "";
                    textBoxPasswordUpdate.Text = "";
                    DateOfBirth.Value = DateTime.Now; // Reset DateOfBirthUpdate value if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Address of SQL Server and Database.
                string connection = "Data Source=LAPTOP-0F2M46LC\\SQLEXPRESS;Initial Catalog=CrudOperation;Integrated Security=True;";

                // Establish Connection.
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    // Open Connection.
                    conn.Open();

                    // Prepare Query.
                    string searchValue = textBoxInfoSearch.Text;
                    string query = @"DELETE FROM userInfo WHERE userID = @SearchValue OR email = @SearchValue OR phoneNumber = @SearchValue;";

                    // Execute Query.
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record deleted. Please verify the ID, email, or phoneNumber.");
                        }
                    }

                    // Close Connection.
                    conn.Close();

                    textBoxFirstNameUpdate.Text = "";
                    textBoxLastNameUpdate.Text = "";
                    textBoxPhoneNumberUpdate.Text = "";
                    textBoxEmailUpdate.Text = "";
                    textBoxPasswordUpdate.Text = "";
                    DateOfBirth.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInfoSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
