using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ABC_car_trade
{
    public partial class RegisterForm : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUserFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUserPassword.Text) ||
                string.IsNullOrWhiteSpace(txtUserPhone.Text) ||
                string.IsNullOrWhiteSpace(txtUserAddress.Text))
            {
                show_Error("Please fill all required Fields!");
                return;
            }




            // Collect user input
            string fullName = txtUserFullName.Text;
            string email = txtUserEmail.Text;
            string password = txtUserPassword.Text;
            string phoneNumber = txtUserPhone.Text;
            string address = txtUserAddress.Text;
            DateTime registrationDate = DateTime.Now;

            if (!IsValidEmail(email))
            {
                show_Error("Email address is invalid Please check!");
                return;
            }


            if (IsEmailTaken(email, connectionString))
            { 
                show_Error("Email address is already taken.");
                return;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                show_Error("Invalid phone number.");

                return;
            }


            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                // Open the connection
                cnn.Open();

                // Prepare the SQL statement
                string sql = "INSERT INTO Users (name, email, password, user_role, phone, address, date) " +
                             "VALUES (@FullName, @Email, @Password, @Role, @PhoneNumber, @Address, @Date)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", EncodePasswordToBase64(password));
                    cmd.Parameters.AddWithValue("@Role", 0);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Address", address); 
                    cmd.Parameters.AddWithValue("@Date", registrationDate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        show_Error("Registration is Success! Please log in");
                        SessionManager.SetLoggedInUser(email);

                        Timer timer = new Timer();
                        timer.Interval = 3000;
                        timer.Tick += (s, args) =>
                        {
                            DashBoard dashBoard = new DashBoard();
                            dashBoard.Show();
                            this.Hide();
                            timer.Stop();
                        };
                        timer.Start();

                    }
                    else
                    { 
                        show_Error("Registration failed!");

                    }
                }
            }
        }

        private void show_Error(String msg)
        {
            lblRegMessage.Visible = true;
            lblRegMessage.Text = msg;
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                lblRegMessage.Visible = false;
                timer.Stop(); // Stop the timer
            };
            timer.Start();
        }

        private bool IsEmailTaken(string email, string connectionString)
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            try
            {
                string pattern = @"^\d{10}$";
                return Regex.IsMatch(phoneNumber, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
