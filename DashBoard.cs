using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_car_trade
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // Initial load the cars form
            ChildCars childCars = new ChildCars() { TopLevel = false, TopMost = true };
            childCars.FormBorderStyle = FormBorderStyle.None;
            MainChildPanel.Controls.Add(childCars);
            childCars.Show();

            // add Active class when load Dashboard
            btnCarsMenuItem.BackColor = SystemColors.Control;
        }

        private void btnLogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            SessionManager.ClearSession();
            loginForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
             
        }

        private void btnCarsMenuItem_Click(object sender, EventArgs e)
        {
            ChildCars childCars = new ChildCars() { TopLevel = false, TopMost = true };
            childCars.FormBorderStyle = FormBorderStyle.None;
            MainChildPanel.Controls.Add(childCars);
            childCars.Show();
        }

        private void btnCarPartsMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm() { TopLevel=false, TopMost=true };
            loginForm.FormBorderStyle = FormBorderStyle.None;
            MainChildPanel.Controls.Add(loginForm);
            loginForm.Show();
        }
    }
}
