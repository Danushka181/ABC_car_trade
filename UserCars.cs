using ABC_car_trade.User;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_car_trade
{
    public partial class UserCars : Form
    {

        string connectionString = DatabaseConnection.GetConnectionString();

        public UserCars()
        {
            InitializeComponent();

            LoadDataToDataGridView();
        }

        private void UserCars_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT * FROM car_details";

                    // Check if search criteria is available
                    if (!string.IsNullOrWhiteSpace(SearchCars.Text))
                    {
                        sql += " WHERE make LIKE @SearchTerm OR model LIKE @SearchTerm OR price LIKE @SearchTerm";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                    {
                        // set parameters
                        if (!string.IsNullOrWhiteSpace(SearchCars.Text))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + SearchCars.Text + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            flowLayoutCars.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                String CarName = row["make"].ToString();
                                String CarModel = row["model"].ToString();
                                String CarDesc = row["description"].ToString();
                                String ImagePath = row["image_url"].ToString();
                                String CarMilage = row["mileage"].ToString();
                                String CarPrice = row["price"].ToString();

                                CarListItem carListItem = new CarListItem();

                                carListItem.CarName = CarModel+" - "+CarName;
                                carListItem.CarDesc = CarDesc;
                                carListItem.CarMilage = CarMilage+" KM";
                                carListItem.CarPrice = CarPrice+" RS";
                                carListItem.CarPiceValue = CarPrice;

                                carListItem.CarId = row["id"].ToString();

                                carListItem.CarImage = Image.FromFile(ImagePath);

                                carListItem.Width = flowLayoutCars.Width;

                                flowLayoutCars.Controls.Add(carListItem);

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

        private void SearchCars_TextChanged(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void flowLayoutCars_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
