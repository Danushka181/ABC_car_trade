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
    public partial class ChildCustomers : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";
        private DataTable dataTable;

        public ChildCustomers()
        {
            InitializeComponent();

            LoadDataToDataGridView();
        }

        private void ChildCustomers_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    cnn.Open();

                    string sql = "SELECT id, name, email, phone, address, date  FROM users WHERE user_role=0";

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

                            DataGridForCustomers.DataSource = dataTable;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Refresh the table
        private void refreshTable_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        // search customers
        private void SearchCustomers_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                string filterExpression = string.Format("[Name] LIKE '%{0}%' OR [Email] LIKE '%{0}%' OR Convert([Phone], 'System.String') LIKE '%{0}%'", SearchCustomers.Text);
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (DataGridForCustomers.SelectedRows.Count > 0)
            {
                int selectedIndex = DataGridForCustomers.SelectedRows[0].Index;
                string selectedCarId = DataGridForCustomers.Rows[selectedIndex].Cells["id"].Value.ToString();

                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        cnn.Open();

                        string sql = "DELETE FROM users WHERE id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@userId", selectedCarId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Selected user deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a user record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
