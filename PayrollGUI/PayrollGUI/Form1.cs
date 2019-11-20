using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_calculate_Click(object sender, EventArgs e)
        {

            double hourlyRate;
            double hoursWorked;
            string name;
            string socialSecurity;
            const double FEDERAL_TAX = 0.15;
            const double STATE_TAX = 0.05;
            double netPay;
            double taxTotal;
            double federalWithhold;
            double stateWithhold;
            double grossPay; 

            hourlyRate = Convert.ToDouble(txtHourlyRate.Text);
            hoursWorked = Convert.ToDouble(txtHoursWorked.Text);
            name = Convert.ToString(txtName.Text);
            socialSecurity = Convert.ToString(txtSocialSecurity.Text);

            grossPay = hoursWorked * hourlyRate;
            federalWithhold = grossPay * FEDERAL_TAX;
            stateWithhold = grossPay * STATE_TAX;
            taxTotal = federalWithhold + stateWithhold;
            netPay = grossPay - taxTotal;

            lblResults.Text = "Name: " + name + "\nSocial Security: " +
                socialSecurity + "\nHours worked: " + hoursWorked +
                "\nHourly Rate: " + hourlyRate + "\nGross Pay: " +
                grossPay + "\nFederal Tax: " + 
                federalWithhold + "\nState Tax: " 
                + stateWithhold + "\nNet Pay: " + netPay;

        }
    }
    
}
