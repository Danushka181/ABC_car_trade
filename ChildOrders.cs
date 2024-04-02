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
    public partial class ChildOrders : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";
        private DataTable dataTable;

        public ChildOrders()
        {
            InitializeComponent();

            PartsLoadDataToDataGridView();
            CarOrdersTable.BackColor = Color.Black;
        }

        private void PartsLoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT cod.id AS order_id, cod.customer_id, u.email AS customer_email, u.phone AS phone, cpd.part_name, cpd.part_price, cpd.part_code, cod.order_date, cod.quantity, cod.total_amount, cod.status, cod.shipping_address FROM customer_order_details cod INNER JOIN users u ON cod.customer_id = u.id INNER JOIN car_parts_details cpd ON cod.part_id = cpd.id";

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

                            DataGridForOrders.DataSource = dataTable;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CarsLoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT cod.id AS order_id, cod.customer_id, u.email AS customer_email, u.phone AS phone, cd.make, cd.price, cd.model, cod.order_date, cod.quantity, cod.total_amount, cod.status, cod.shipping_address FROM customer_order_details cod INNER JOIN users u ON cod.customer_id = u.id INNER JOIN car_details cd ON cod.car_details_id = cd.id";

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

                            DataGridForOrders.DataSource = dataTable;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ChildOrders_Load(object sender, EventArgs e)
        {

        }

        private void CarOrdersTable_Click(object sender, EventArgs e)
        {
            CarOrdersTable.BackColor = Color.Black;
            PartOrdersTable.BackColor = Color.FromArgb(0,19,47);
            PartsLoadDataToDataGridView();
        }

        private void PartOrdersTable_Click(object sender, EventArgs e)
        {
            PartOrdersTable.BackColor = Color.Black;
            CarOrdersTable.BackColor = Color.FromArgb(0, 19, 47);
            CarsLoadDataToDataGridView();
        }
    }
}
