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

namespace ABC_car_trade.User
{
    public partial class OrderPart : Form
    {
        public String PartId { get; set; }
        public String Price { get; set; }
        public String Total { get; set; }

        public String fullAmount { get; set; }

        string connectionString = DatabaseConnection.GetConnectionString();

        public OrderPart(string PartId, string carPrice)
        {
            InitializeComponent();

            this.PartId = PartId;
            this.Price = carPrice;
            fullAmount = carPrice;
            
            loadPartData();
        }

        private void loadPartData()
        {
            quantityBox.SelectedIndex = quantityBox.FindString("1");
            totalPrice.Text = Price;
            fullAmount = Price;
        }

        private void OrderPart_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            string partQuantity = quantityBox.SelectedItem != null ? quantityBox.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(partQuantity))
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
                SaveDataToDatabase(userId, this.PartId, null, OrderDate, quantity, fullAmount, "Pending", Address);
                show_Error("Order created Successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong!");
            }
        }

        public void SaveDataToDatabase(string userID, string partId, string carId, DateTime date, string qty, string amount, string status, string address)
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
                        show_Error("Order creation is Success!");

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
                        show_Error("Order failed!");

                    }
                }
            }
        }

        private void quantityBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String Quantity = quantityBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(Quantity))
            {
                show_Error("Please select Quantity");
                return;
            }

            decimal quantity = decimal.Parse(Quantity);
            decimal partPrice = decimal.Parse(Price);

            decimal carTotal = quantity * partPrice;

            Total = carTotal.ToString();

            totalPrice.Text = Total.ToString();

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
         
    }
}
