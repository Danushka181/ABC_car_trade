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
    public partial class OrderItem : UserControl
    {
        public string ItemName
        {
            get { return itemName.Text; }
            set { itemName.Text = value; }
        }

        public string ItemDesc
        {
            get { return itemDesc.Text; }
            set { itemDesc.Text = value; }
        }

        public Image ItemImage
        {
            get { return pbCarImage.Image; }
            set { pbCarImage.Image = value; }
        }

        public string ItemStatus
        {
            get { return itemStatus.Text; }
            set { itemStatus.Text = value; }
        }

        public string ItemPrice
        {
            get { return itemPrice.Text; }
            set { itemPrice.Text = value; }
        }

        public string ItemDate
        {
            get { return itemPrice.Text; }
            set { itemPrice.Text = value; }
        }

        public OrderItem()
        {
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {

        }
    }
}
