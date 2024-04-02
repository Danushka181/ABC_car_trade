using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_car_trade.User
{
    public partial class CarListItem : UserControl
    {
        public string CarName
        {
            get { return lblCarName.Text; }
            set { lblCarName.Text = value; }
        }

        public string CarDesc
        {
            get { return lblCarDesc.Text; }
            set { lblCarDesc.Text = value; }
        }

        public Image CarImage
        {
            get { return pbCarImage.Image; }
            set { pbCarImage.Image = value; }
        }

        public string CarMilage
        {
            get { return lblMilage.Text; }
            set { lblMilage.Text = value; }
        }

        public string CarPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string CarId { get; set; }
        public string CarPiceValue { get; set; }


        public CarListItem()
        {
            InitializeComponent();
        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            string carId = CarId;
            OrderCars cars = new OrderCars(CarId, CarPiceValue);
            cars.ShowDialog();
        }
    }
}
