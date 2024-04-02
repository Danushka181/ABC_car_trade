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
    public partial class UserDashboard: Form
    {
        public UserDashboard()
        {
            InitializeComponent();

            loadCarsPanelData();
        }

        private void btnCarsMenuItem_Click(object sender, EventArgs e)
        {
            loadCarsPanelData();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void MainChildPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadCarsPanelData()
        {
            MainChildPanel.Controls.Clear();

            UserCars userCars = new UserCars() { TopLevel=false, TopMost=true };
            userCars.FormBorderStyle = FormBorderStyle.None;
            MainChildPanel.Controls.Add(userCars);
            userCars.Show();
        }

        private void btnCarPartsMenuItem_Click(object sender, EventArgs e)
        {
            MainChildPanel.Controls.Clear();


            UserCarParts userCarParts = new UserCarParts() { TopLevel = false, TopMost=true };
            userCarParts.FormBorderStyle = FormBorderStyle.None;
            MainChildPanel.Controls.Add(userCarParts);
            userCarParts.Show();
        }
    }
}
