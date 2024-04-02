using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ABC_car_trade
{
    public partial class EditCarPartAdmin : Form
    {
        // Local parameters to save values
        private String selectedId;
        private string _partName;
        private string _partCategory;
        private string _partDescription;
        private decimal _partPrice;
        private int _partQuantity;
        private string _partSupplier;
        private string _partCode;
        private string _suitableVehicleModel;
        private string _warrantyPeriod;
        private string _partImageUrl;

        string connectionString = "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";

        String carPartImage = null;

        public EditCarPartAdmin(
            string selectedId,
            string partName,
            string partCategory,
            string partDescription,
            decimal partPrice,
            int partQuantity,
            string partSupplier,
            string partCode,
            string suitableVehicleModel,
            string warrantyPeriod,
            string partImageUrl)
        {
            InitializeComponent();

            this.selectedId     = selectedId;
            _partName           = partName;
            _partCategory       = partCategory;
            _partDescription    = partDescription;
            _partPrice          = partPrice;
            _partQuantity       = partQuantity;
            _partSupplier       = partSupplier;
            _partCode           = partCode;
            _suitableVehicleModel = suitableVehicleModel;
            _warrantyPeriod     = warrantyPeriod;
            _partImageUrl       = partImageUrl;

            carPartImage = partImageUrl;

            setValuesToTheForm();
        }


        private void EditCarPartAdmin_Load(object sender, EventArgs e)
        {
        }

        private void setValuesToTheForm()
        {

            try
            {
                partCategory.SelectedIndex = partCategory.FindString(this._partCategory);
                partName.Text           = this._partName.ToString();
                partQuantity.Text       = this._partQuantity.ToString();
                fieldPrice.Text         = this._partPrice.ToString();
                partSuplier.Text        = this._partSupplier.ToString();
                partCode.Text           = this._partCode.ToString();
                partForVehicle.Text     = this._suitableVehicleModel.ToString();
                partWarenty.Text   = this._warrantyPeriod.ToString();
                partDescription.Text   = this._partDescription.ToString();

                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(this._partImageUrl);
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

                        carPartImage = selectedImagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

                string query = "UPDATE car_parts_details SET part_name = @Name, part_category = @cat, part_description = @desc, part_price = @price, part_quantity = @qty, part_supplier = @supl, part_code = @code, suitable_vehicle_model = @vmodel, warranty_period = @warrenty, part_image_url = @img WHERE id = @part_id";

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
                command.Parameters.AddWithValue("@img", carPartImage);
                command.Parameters.AddWithValue("@part_id", selectedId);


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
    }
}
