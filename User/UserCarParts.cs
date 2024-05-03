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

        string connectionString = DatabaseConnection.GetConnectionString();

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
                                String Name = row["part_name"].ToString();
                                String Caegory = row["part_category"].ToString();
                                String Desc = row["part_description"].ToString();
                                String ImagePath = row["part_image_url"].ToString();
                                String Code = row["part_code"].ToString();
                                String Price = row["part_price"].ToString();

                                CarListItem carListItem = new CarListItem();

                                CarPartListItem partListItem = new CarPartListItem();
                                // showing data
                                partListItem.PartName       = Caegory+" - "+Name;
                                partListItem.Desc           = Desc;
                                partListItem.Code           = "CODE : "+Code;
                                partListItem.Price          = Price+" RS";
                                partListItem.CarPiceValue   = Price;
                                // process data
                                partListItem.PartId         = row["id"].ToString();
                                partListItem.ImagePath      = Image.FromFile(ImagePath);
                                partListItem.Width          = flowLayoutCarParts.Width;
                                flowLayoutCarParts.Controls.Add(partListItem); 
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

        // Filter data when user searching something
        private void SearchCarParts_TextChanged(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
