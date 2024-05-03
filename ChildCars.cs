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

namespace ABC_car_trade
{
    public partial class ChildCars : Form
    {

        string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable dataTable;

        public ChildCars()
        {
            InitializeComponent();

            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT * FROM car_details";

                    using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);  

                            DataGridForCars.DataSource = dataTable;

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void TestButton_Click(object sender, EventArgs e)
        {
        }

        private void CarsMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChildCars_Load(object sender, EventArgs e)
        {

        }

        private void DataGridForCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchCars_TextChanged_1(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string filterExpression = string.Format("make LIKE '%{0}%' OR model LIKE '%{0}%' OR Convert(manufacturing_year, 'System.String') LIKE '%{0}%'", SearchCars.Text);
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCar addNewCar = new AddNewCar();
            addNewCar.ShowDialog();
        }

        private void refreshTable_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DataGridForCars.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridForCars.SelectedRows[0].Index;
                string selectedCarId = DataGridForCars.Rows[selectedIndex].Cells["id"].Value.ToString();

                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        cnn.Open();

                        string sql = "DELETE FROM car_details WHERE id = @carId";

                        using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@carId", selectedCarId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Selected car record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataToDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete selected car record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a car record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (DataGridForCars.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridForCars.SelectedRows[0].Index;
                string selectedCarId = DataGridForCars.Rows[selectedIndex].Cells["id"].Value.ToString();

                DataRow[] selectedCarRows = dataTable.Select($"id = {selectedCarId}");
                if (selectedCarRows.Length > 0)
                {
                    string make = selectedCarRows[0]["make"].ToString();
                    string model = selectedCarRows[0]["model"].ToString();
                    int manufacturingYear = Convert.ToInt32(selectedCarRows[0]["manufacturing_year"]);
                    decimal price = Convert.ToDecimal(selectedCarRows[0]["price"]);
                    string color = selectedCarRows[0]["color"].ToString();
                    decimal mileage = Convert.ToDecimal(selectedCarRows[0]["mileage"]);
                    decimal engineCapacity = Convert.ToDecimal(selectedCarRows[0]["engine_type"]);
                    string transmission = selectedCarRows[0]["transmission"].ToString();
                    string fuelType = selectedCarRows[0]["fuel_type"].ToString();
                    string description = selectedCarRows[0]["description"].ToString();
                    string imageUrl = selectedCarRows[0]["image_url"].ToString();

                    // Open the edit form and pass the selected car's data
                    EditCarForm editCarForm = new EditCarForm(selectedCarId, make, model, manufacturingYear, price, color, mileage, engineCapacity, transmission, fuelType, description, imageUrl); 
                    editCarForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected car record not found in the data table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a car record to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
