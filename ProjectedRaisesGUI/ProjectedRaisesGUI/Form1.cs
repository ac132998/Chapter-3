using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class ProjectedRaises : Form
    {
        public ProjectedRaises()
        {
            InitializeComponent();
        }

        private void btn_estimateRaise_Click(object sender, EventArgs e)
        {
            intdouble employeeSalary;
            const double RAISE = 0.04;
            double projectedSalary;


            employeeSalary = Convert.ToDouble(txtSalary.Text);
            projectedSalary = (employeeSalary * RAISE) + employeeSalary;

            lblProjRaise.Text = "Projected Salary is " + projectedSalary;

        }
    }
}
