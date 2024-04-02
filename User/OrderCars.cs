using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_car_trade.User
{
    public partial class OrderCars : Form
    {
        public String CarId {  get; set; }
        public String CarPrice { get; set; }
        public String CarTotal { get; set; }

        public String fullAmount { get; set; }


        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        public OrderCars( string CarId, string carPrice)
        {
            InitializeComponent();

            this.CarId = CarId;
            this.CarPrice = carPrice;
            fullAmount = carPrice;

            loadCarData(); 
        }


        private void loadCarData()
        {
            quantityBox.SelectedIndex = quantityBox.FindString("1");
            totalPrice.Text = CarPrice;
            fullAmount = CarPrice;
        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            string typeOfFuel = quantityBox.SelectedItem != null ? quantityBox.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(typeOfFuel))
            {
                show_Error("Please select Quantity");
                return;
            }

            String userId = SessionManager.UserId;
            DateTime OrderDate = DateTime.Now;
            string quantity = quantityBox.SelectedItem.ToString();
            string Address = shippingAddress.Text;

            try
            {
                SaveDataToDatabase(userId, null, this.CarId, OrderDate, quantity, fullAmount, "Pending", Address);
                show_Error("Order created Successfully!");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong!");
            }


        }

        public void SaveDataToDatabase( string userID, string partId, string carId, DateTime date, string qty, string amount, string status, string address )
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                // Open the connection
                cnn.Open();

                // Prepare the SQL statement
                string sql = "INSERT INTO customer_order_details (customer_id, part_id, car_details_id, order_date, quantity, total_amount, status, shipping_address) " +
                             "VALUES (@Customer, @Part,@Car, @Date, @Qty, @Amount, @Status, @Address)";

                // Create a MySqlCommand object
                using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@Customer", userID);
                    cmd.Parameters.AddWithValue("@Part", partId);
                    cmd.Parameters.AddWithValue("@Car", carId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Qty", qty);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        show_Error("Registration is Success! Please log in");

                        Timer timer = new Timer();
                        timer.Interval = 3000;
                        timer.Tick += (s, args) =>
                        { 
                            timer.Stop();
                            this.Close();
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
            orderMessage.Visible = true;
            orderMessage.Text = msg;
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                orderMessage.Visible = false;
                timer.Stop(); // Stop the timer
            };
            timer.Start();
        }

        private void quantityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Quantity =  quantityBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(Quantity))
            {
                show_Error("Please select Quantity");
                return;
            }

            decimal quantity = decimal.Parse(Quantity);
            decimal carPrice = decimal.Parse(CarPrice);

            decimal carTotal = quantity * carPrice; 

            CarTotal = carTotal.ToString(); 

            totalPrice.Text = CarTotal.ToString();

         
        }
    }
}
