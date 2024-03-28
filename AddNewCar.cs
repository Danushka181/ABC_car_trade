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

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

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
            MySqlConnection cnn = new MySqlConnection(connectionString);

            string selectedVehicleMake = fieldVehicleMake.SelectedItem != null ? fieldVehicleMake.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(selectedVehicleMake))
            { 
                show_Error("Please select a Vehicle Make");
                return;
            }

            string vehicleModel = fieldModel.Text;
            if( string.IsNullOrEmpty(vehicleModel))
            {
                show_Error("Please add Vehicle Model");
                return;
            }

            string vehicleYear = fieldCalenderYear.Text;
            if (string.IsNullOrEmpty(vehicleYear))
            {
                show_Error("Please add Vehicle Year");
                return;
            }

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

            string vehicleMilage = fieldColor.Text;
            if (string.IsNullOrEmpty(vehicleMilage))
            {
                show_Error("Please add Vehicle Milage");
                return;
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
    }
}
