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
    public partial class AddNewPartAdmin : Form
    {

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        String PartImagePath = null;

        public AddNewPartAdmin()
        {
            InitializeComponent();
        }

        private void btnCancelSaveCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            string _partCategory = partCategory.SelectedItem != null ? partCategory.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(_partCategory))
            {
                show_Error("Please select Category");
                return;
            }

            string _partName = partName.Text;
            if (string.IsNullOrEmpty(_partName))
            {
                show_Error("Please add a Name to Part");
                return;
            }
            
            string _partCode = partCode.Text;
            if (string.IsNullOrEmpty(_partCode))
            {
                show_Error("Please add a Code for the Part");
                return;
            }

            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();

                string query = "INSERT INTO car_parts_details (part_name, part_category, part_description, part_price, part_quantity, part_supplier, part_code, suitable_vehicle_model, warranty_period, part_image_url) " +
                               "VALUES (@Name, @cat, @desc, @price, @qty, @supl,@code, @vmodel, @warrenty, @img)";
                MySqlCommand command = new MySqlCommand(query, cnn); 

                command.Parameters.AddWithValue("@Name", _partName);
                command.Parameters.AddWithValue("@cat", _partCategory);
                command.Parameters.AddWithValue("@desc", partDescription.Text);
                command.Parameters.AddWithValue("@price", Convert.ToDecimal(fieldPrice.Text));
                command.Parameters.AddWithValue("@qty", Convert.ToInt32(partQuantity.Text));
                command.Parameters.AddWithValue("@supl", partSuplier.Text);
                command.Parameters.AddWithValue("@code", partCode.Text);
                command.Parameters.AddWithValue("@vmodel", partForVehicle.Text);
                command.Parameters.AddWithValue("@warrenty", partWarenty.Text);
                command.Parameters.AddWithValue("@img", PartImagePath);


                // Execute the sql commads
                command.ExecuteNonQuery();

                MessageBox.Show("Car Part saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashBoard dashBoard = new DashBoard();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }


        }

        private void show_Error(String msg)
        {
            lblErrorSave.Visible = true;
            lblErrorSave.Text = msg;
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                lblErrorSave.Visible = false;
                timer.Stop(); // Stop the timer
            };
            timer.Start();
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                {
                    try
                    {
                        string selectedImagePath = openFileDialog.FileName;
                        carImage.Image = Image.FromFile(selectedImagePath);

                        PartImagePath = selectedImagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddNewPartAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
