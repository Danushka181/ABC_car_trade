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

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";
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
    }
}
