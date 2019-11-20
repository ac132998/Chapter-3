using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_contestants_Click(object sender, EventArgs e)
        {
            int lastYearsNum;
            int thisYearNum;
            const int ENTRY_FEE = 25;
            int thisYearRevenue;

            lastYearsNum = Convert.ToInt32(txtlastyearsnum.Text);
            thisYearNum = Convert.ToInt32(txtthisyearnum.Text);

            thisYearRevenue = thisYearNum * ENTRY_FEE;

           
            if (thisYearNum > lastYearsNum)
            {
               
                lblTotalRevenue.Text = "The expected revenue from this year's competition is " +
               thisYearRevenue + "\nThis year's competition has " +
                      "more contestants.";
            }
            else 
            {
                lblTotalRevenue.Text = "\nLast year's competitition has " +
                    "more contestants.";
            }



        }
    }
}
