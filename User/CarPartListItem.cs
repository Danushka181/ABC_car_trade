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
    public partial class CarPartListItem : UserControl
    {
        public string PartName
        {
            get { return lblCarName.Text; }
            set { lblCarName.Text = value; }
        }

        public string Desc
        {
            get { return lblCarDesc.Text; }
            set { lblCarDesc.Text = value; }
        }

        public Image ImagePath
        {
            get { return pbCarImage.Image; }
            set { pbCarImage.Image = value; }
        }

        public string Code
        {
            get { return lblMilage.Text; }
            set { lblMilage.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string PartId { get; set; }
        public string CarPiceValue { get; set; }
        public CarPartListItem()
        {
            InitializeComponent();
        }

        private void lblCarName_Click(object sender, EventArgs e)
        {

        }

        private void CarPartListItem_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            string PartId = this.PartId;
            OrderPart orderPart = new OrderPart(PartId, CarPiceValue);
            orderPart.ShowDialog();

        }
    }
}
