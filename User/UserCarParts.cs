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
    public partial class UserCarParts : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        public UserCarParts()
        {
            InitializeComponent();

            LoadDataToDataGridView();
        }

        private void UserCarParts_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT * FROM car_parts_details";

                    // Check if search criteria is available
                    if (!string.IsNullOrWhiteSpace(SearchCarParts.Text))
                    {
                        sql += " WHERE part_name LIKE @SearchTerm OR part_category LIKE @SearchTerm OR part_price LIKE @SearchTerm OR part_code LIKE @SearchTerm OR suitable_vehicle_model LIKE @SearchTerm";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                    {
                        // set parameters
                        if (!string.IsNullOrWhiteSpace(SearchCarParts.Text))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + SearchCarParts.Text + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            flowLayoutCarParts.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                String CarName = row["part_name"].ToString();
                                String CarModel = row["part_category"].ToString();
                                String CarDesc = row["part_description"].ToString();
                                String ImagePath = row["part_image_url"].ToString();
                                String CarMilage = row["part_code"].ToString();
                                String CarPrice = row["part_price"].ToString();

                                CarListItem carListItem = new CarListItem();

                                carListItem.CarName = CarModel+" - "+CarName;
                                carListItem.CarDesc = CarDesc;
                                carListItem.CarMilage = "CODE : "+CarMilage;
                                carListItem.CarPrice = CarPrice+" RS";
                                carListItem.CarPiceValue = CarPrice;

                                carListItem.CarId = row["id"].ToString();

                                carListItem.CarImage = Image.FromFile(ImagePath);

                                carListItem.Width = flowLayoutCarParts.Width;

                                flowLayoutCarParts.Controls.Add(carListItem);

                                // Add the custom control to the FlowLayoutPanel
                                //flowLayoutPanel1.Controls.Add(customControl);
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
