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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_car_trade
{
    public partial class AddNewCar : Form
    {

        string connectionString = DatabaseConnection.GetConnectionString();

        String carImagePath = null;

        public AddNewCar()
        {
            InitializeComponent();
        }

        private void btnCancelSaveCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            // validate vehicle make combobox value
            string selectedVehicleMake = fieldVehicleMake.SelectedItem != null ? fieldVehicleMake.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(selectedVehicleMake))
            { 
                show_Error("Please select a Vehicle Make");
                return;
            }
            // validate textInput value for model
            string vehicleModel = fieldModel.Text;
            if( string.IsNullOrEmpty(vehicleModel))
            {
                show_Error("Please add Vehicle Model");
                return;
            }
            // validate Year combobox value
            string vehicleYear = manufatureYear.SelectedItem != null ? manufatureYear.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(vehicleYear))
            {
                show_Error("Please add Vehicle Year");
                return;
            }
            // validate pice value
            string vehiclePrice = fieldPrice.Text;
            if (string.IsNullOrEmpty(vehiclePrice))
            {
                show_Error("Please add Vehicle year");
                return;
            }
            // validate color field
            string vehicleColor = fieldColor.Text;
            if (string.IsNullOrEmpty(vehicleColor))
            {
                show_Error("Please add Vehicle color");
                return;
            }
            // validate engine capacity
            string engineCC = fieldEngineCapacity.Text;
            if (string.IsNullOrEmpty(engineCC))
            {
                show_Error("Please add Vehicle color");
                return;
            }
            // validate Milage
            string vehicleMilage = fieldMilage.Text;
            if (string.IsNullOrEmpty(vehicleMilage))
            {
                show_Error("Please add Vehicle Milage");
                return;
            }
            // Validate Transmission type
            string transmissionType = fieldTransmissions.SelectedItem != null ? fieldTransmissions.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(transmissionType))
            {
                show_Error("Please select Transmisson Type");
                return;
            }
            // Validate fuel type
            string typeOfFuel = fieldFuels.SelectedItem != null ? fieldFuels.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(typeOfFuel))
            {
                show_Error("Please select a Fuel type of the Vehicle");
                return;
            }
            // Validate car Image
            if (string.IsNullOrEmpty(this.carImagePath))
            {
                show_Error("Please add a Image for Vehicle");
                return;
            }

            // save data to mysql database
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                 
                string query = "INSERT INTO car_details (make, model, manufacturing_year, price, color, mileage, engine_type, transmission, fuel_type, description, image_url) " +
                               "VALUES (@make, @model, @year, @price, @color, @mileage,@engine_type, @transmission, @fuel, @desc, @image_url)";
                MySqlCommand command = new MySqlCommand(query, cnn);
                command.Parameters.AddWithValue("@make", fieldVehicleMake.SelectedItem.ToString());
                command.Parameters.AddWithValue("@model", fieldModel.Text);
                command.Parameters.AddWithValue("@year", manufatureYear.SelectedItem.ToString());
                command.Parameters.AddWithValue("@price", Convert.ToDecimal(fieldPrice.Text));
                command.Parameters.AddWithValue("@color", fieldColor.Text);
                command.Parameters.AddWithValue("@mileage", Convert.ToDecimal(fieldMilage.Text));
                command.Parameters.AddWithValue("@engine_type", Convert.ToDecimal(fieldEngineCapacity.Text));
                command.Parameters.AddWithValue("@transmission", fieldTransmissions.SelectedItem.ToString());
                command.Parameters.AddWithValue("@fuel", fieldFuels.SelectedItem.ToString());
                command.Parameters.AddWithValue("@desc", fieldDescription.Text);
                command.Parameters.AddWithValue("@image_url", carImagePath);

                // Execute the sql commads
                command.ExecuteNonQuery();

                MessageBox.Show("Car details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
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

        private void AddNewCar_Load(object sender, EventArgs e)
        {

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

                        carImagePath = selectedImagePath; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
