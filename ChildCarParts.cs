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
    public partial class ChildCarParts : Form
    {

        string connectionString = DatabaseConnection.GetConnectionString();
        private DataTable dataTable;

        public ChildCarParts()
        {
            InitializeComponent();

            LoadDataToDataGridView();
        }

        private void CarsMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChildCarParts_Load(object sender, EventArgs e)
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

                    using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            foreach (DataColumn column in dataTable.Columns)
                            { 
                                string columnName = column.ColumnName.Replace("_", " ");
                                columnName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(columnName.ToLower());
                                 
                                column.ColumnName = columnName;
                            }

                            DataGridForCarParts.DataSource = dataTable;


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
            if (dataTable != null)
            {
                string filterExpression = string.Format("[Part Name] LIKE '%{0}%' OR [Part Category] LIKE '%{0}%' OR Convert([Part Code], 'System.String') LIKE '%{0}%'", SearchCars.Text);
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        // Refresh table data.
        private void refreshTable_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewPartAdmin addNewPartAdmin = new AddNewPartAdmin();
            addNewPartAdmin.ShowDialog();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (DataGridForCarParts.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridForCarParts.SelectedRows[0].Index;
                string selectedCarId = DataGridForCarParts.Rows[selectedIndex].Cells["id"].Value.ToString();

                DataRow[] selectedCarRows = dataTable.Select($"id = {selectedCarId}");
                if (selectedCarRows.Length > 0)
                {
                    string partName         = selectedCarRows[0]["Part Name"].ToString();
                    string partCategory     = selectedCarRows[0]["Part Category"].ToString();
                    int partQuantity        = Convert.ToInt32(selectedCarRows[0]["Part Quantity"]);
                    decimal partPrice       = Convert.ToDecimal(selectedCarRows[0]["Part Price"]);
                    string warrantyPeriod   = selectedCarRows[0]["Warranty Period"].ToString();
                    string suitableVehicleModel = selectedCarRows[0]["Suitable Vehicle Model"].ToString();
                    string partSupplier     = selectedCarRows[0]["Part Supplier"].ToString();
                    string partCode         = selectedCarRows[0]["Part Code"].ToString();
                    string partDescription  = selectedCarRows[0]["Part Description"].ToString();
                    string partImageUrl     = selectedCarRows[0]["Part Image Url"].ToString();

                    // Open the edit form and pass the selected car part data
                    EditCarPartAdmin editCarPartAdmin = new EditCarPartAdmin(selectedCarId, partName,partCategory,partDescription,partPrice,partQuantity,partSupplier,partCode,suitableVehicleModel,warrantyPeriod,partImageUrl);
                    editCarPartAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected car psrt record not found in the data table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a car part record to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
