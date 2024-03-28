﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ABC_car_trade
{
    public partial class LoginForm : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";


        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /**
         * Login button clicked function
         * 
         */
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);

            DashBoard dashBoard1 = new DashBoard();
            dashBoard1.Show();
            this.Hide();

            String userName = txtUserName.Text;
            String password = txtPassword.Text;

            if ( userName == "" )
            {

                show_Error("User name is required and cannot be empty!");
                return;
            }

            if ( password == "")
            {
                show_Error("Password is required and cannot be empty!");
                return;
            }

            try
            {
                cnn.Open();
                 
                string sql = "SELECT COUNT(*) FROM users WHERE email = @UserName AND password = @Password";

                // use database connection
                using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                {

                    // set parameters using cmd parameters
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", EncodePasswordToBase64(password));
                     
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        show_Error("Authenticating..");
                        SessionManager.SetLoggedInUser(userName);

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
                        // Login failed message show
                        this.show_Error("Invalid username or password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to the database!"+ex);
            }

        }

        /**
         * Show commom message and hide after 3 seconds 
         * @param String msg
         */
        private void show_Error(String msg)
        {
            lblLoginError.Visible = true;
            lblLoginError.Text = msg;
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                lblLoginError.Visible = false;
                timer.Stop(); // Stop the timer
            };
            timer.Start();
        }

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}