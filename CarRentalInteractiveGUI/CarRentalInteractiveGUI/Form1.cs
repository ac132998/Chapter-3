using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class CarRentalCalculator : Form
    {
        public CarRentalCalculator()
        {
            InitializeComponent();
        }

        private void btn_carRentalTotal_Click(object sender, EventArgs e)
        {

            int daysEntered;
            double milesEntered;
            double milesRented;
            int daysRented;
            double rentalTotal;
            const int DAYS_RENTAL_PRICE = 20;
            const double MILES_RENTAL_PRICE = 0.25;

            milesEntered = Convert.ToDouble(txtMiles.Text);
            daysEntered = Convert.ToInt32(txtDays.Text);

            milesRented = milesEntered * MILES_RENTAL_PRICE;
            daysRented = daysEntered * DAYS_RENTAL_PRICE;
            rentalTotal = milesRented + daysRented;

            lblTotalRental.Text = "Total rental cost is " + rentalTotal; 
            

        }
    }
}
