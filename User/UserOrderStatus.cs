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
    public partial class UserOrderStatus : Form
    {
        String connectionString  = DatabaseConnection.GetConnectionString();
        public UserOrderStatus()
        {
            InitializeComponent();

            LoadDataToGridView();
        }

        private void UserOrderStatus_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToGridView()
        { 
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT cod.car_details_id, cod.part_id, cd.make, cd.model, cd.price, cd.image_url, cd.description, cod.order_date, cod.quantity, cod.status, cod.total_amount, cpd.part_name, cpd.part_code, cpd.part_price, cpd.part_description, cpd.part_image_url FROM customer_order_details AS cod LEFT JOIN  car_details AS cd ON cod.car_details_id = cd.id LEFT JOIN car_parts_details AS cpd ON cpd.id = cod.part_id;";


                    using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                    { 

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            //flowLayoutCarParts.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                 

                                string ItemName = string.IsNullOrEmpty(row["part_name"]?.ToString()) ? row["model"].ToString() : row["part_name"].ToString();
                                string ItemDesc = string.IsNullOrEmpty(row["part_description"]?.ToString()) ? row["description"]?.ToString() : row["part_description"].ToString();
                                string ItemPrice = string.IsNullOrEmpty(row["part_price"]?.ToString()) ? row["price"]?.ToString() : row["part_price"].ToString();
                                string ImagePath = string.IsNullOrEmpty(row["part_image_url"]?.ToString()) ? row["image_url"]?.ToString() : row["part_image_url"].ToString();
                                string ItemStatus = row["status"]?.ToString();
                                string ItemDate = row["order_date"]?.ToString();

                                OrderItem item = new OrderItem();

                                item.ItemName = ItemName;
                                item.ItemDesc = ItemDesc;
                                item.ItemPrice = ItemPrice;
                                item.ItemStatus = ItemStatus;
                                item.ItemDate = ItemDate;


                                Console.WriteLine(ImagePath);
                                if (ImagePath != "" )
                                {
                                    item.ItemImage = Image.FromFile(ImagePath);

                                }


                                //carListItem.CarId = row["id"].ToString();


                                item.Width = flowLayoutOrders.Width;

                                flowLayoutOrders.Controls.Add(item);
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
    }
}
