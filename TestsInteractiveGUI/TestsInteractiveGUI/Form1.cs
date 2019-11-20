using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_claculateaverage_Click(object sender, EventArgs e)
        {
            double testEntry1;
            double testEntry2;
            double testEntry3;
            double testEntry4;
            double testEntry5;
            double testAverage;

            testEntry1 = Convert.ToDouble(txtTest1.Text);
            testEntry2 = Convert.ToDouble(txtTest2.Text);
            testEntry3 = Convert.ToDouble(txtTest3.Text);
            testEntry4 = Convert.ToDouble(txtTest4.Text);
            testEntry5 = Convert.ToDouble(txtTest5.Text);

            testAverage = (testEntry1 + testEntry2 + testEntry3 +
                testEntry4 + testEntry5) / 5;
            testAverage = Math.Round(testAverage, 2);

            lblTestAverage.Text = "The average test score is " + testAverage;

        }
        
    }
}
