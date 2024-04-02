using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_car_trade
{
    public partial class EditCarForm : Form
    {

        private String selectedCarId;
        private String make;
        private String model;
        private int manufacturingYear;
        private decimal price;
        private String color;
        private decimal mileage;
        private decimal engineCapacity;
        private String transmission;
        private String fuelType;
        private String description;
        private String imageUrl;

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        String carImagePath = null;

        public EditCarForm(String selectedCarId, String make, String model, int manufacturingYear, decimal price, String color, decimal mileage, decimal engineCapacity, String transmission, String fuelType, String description, String imageUrl )
        {
            InitializeComponent();

            this.selectedCarId = selectedCarId;
            this.make = make.ToString();
            this.model = model;
            this.manufacturingYear = manufacturingYear;
            this.price = price;
            this.color = color;
            this.mileage = mileage;
            this.engineCapacity = engineCapacity;
            this.transmission = transmission;
            this.fuelType = fuelType;
            this.description = description;
            this.imageUrl = imageUrl;
            this.carImagePath = imageUrl;


            setValuesToTheForm();


        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {

        }

        private void setValuesToTheForm()
        { 
             
            try
            {
                fieldVehicleMake.SelectedIndex = fieldVehicleMake.FindString(this.make);
                fieldPrice.Text = this.price.ToString();
                fieldTransmissions.SelectedIndex = fieldTransmissions.FindString(this.transmission);
                manufatureYear.SelectedIndex = manufatureYear.FindString(this.manufacturingYear.ToString());
                fieldModel.Text = this.model.ToString();
                fieldColor.Text = this.color.ToString();
                fieldMilage.Text = this.mileage.ToString();
                fieldEngineCapacity.Text = this.engineCapacity.ToString();
                fieldFuels.SelectedIndex = fieldFuels.FindString(this.fuelType.ToString());
                fieldDescription.Text = this.description.ToString();

                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(this.imageUrl); 
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    carImage.Image = Image.FromStream(ms);
                }

                carImage.Size = new Size(284, 155);
                carImage.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error loading data: " + ex.Message);
            }
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
            if (string.IsNullOrEmpty(vehicleModel))
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

            string vehicleColor = fieldColor.Text;
            if (string.IsNullOrEmpty(vehicleColor))
            {
                show_Error("Please add Vehicle color");
                return;
            }

            string engineCC = fieldEngineCapacity.Text;
            if (string.IsNullOrEmpty(engineCC))
            {
                show_Error("Please add Vehicle color");
                return;
            }

            string vehicleMilage = fieldMilage.Text;
            if (string.IsNullOrEmpty(vehicleMilage))
            {
                show_Error("Please add Vehicle Milage");
                return;
            }

            string transmissionType = fieldTransmissions.SelectedItem != null ? fieldTransmissions.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(transmissionType))
            {
                show_Error("Please select Transmisson Type");
                return;
            }

            string typeOfFuel = fieldFuels.SelectedItem != null ? fieldFuels.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(typeOfFuel))
            {
                show_Error("Please select a Fuel type of the Vehicle");
                return;
            }

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

                string query = "UPDATE car_details SET make = @make, model = @model, manufacturing_year = @year, price = @price, " +
                               "color = @color, mileage = @mileage, engine_type = @engine_type, transmission = @transmission, " +
                               "fuel_type = @fuel, description = @desc, image_url = @image_url WHERE id = @car_id";

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
                command.Parameters.AddWithValue("@car_id", selectedCarId);

                command.ExecuteNonQuery();

                MessageBox.Show("Car details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the EditCarForm
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
