﻿using System;
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
    public partial class ReportsChild : Form
    {
        public ReportsChild()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // get the selected date 
            DateTime selectedDate = dateTimePicker1.Value;
            // get the selected date in string format
            string selectedDateString = selectedDate.ToString("yyyy-MM-dd");

            MessageBox.Show(selectedDateString);
        }
    }
}
