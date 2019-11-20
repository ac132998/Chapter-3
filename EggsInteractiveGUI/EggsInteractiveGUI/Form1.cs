using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculateEggs_Click(object sender, EventArgs e)
        {
            int eggsEntry1;
            int eggsEntry2;
            int eggsEntry3;
            int eggsEntry4;
            int eggsEntry5;
            const int DOZEN = 12;
            int subTotalEggs;
            int dozenEggs;
            int remainderEggs;

            eggsEntry1 = Convert.ToInt32(txtEggs1.Text);
            eggsEntry2 = Convert.ToInt32(txtEggs2.Text);
            eggsEntry3 = Convert.ToInt32(txtEggs3.Text);
            eggsEntry4 = Convert.ToInt32(txtEggs4.Text);
            eggsEntry5 = Convert.ToInt32(txtEggs5.Text);

            subTotalEggs = eggsEntry1 + eggsEntry2 + eggsEntry3
                + eggsEntry4 + eggsEntry5;
            dozenEggs = subTotalEggs / DOZEN;
            remainderEggs = subTotalEggs % DOZEN;

            lbleggstotal.Text = String.Format("{0} eggs is {1} dozens with {2} remaining",
                subTotalEggs, dozenEggs, remainderEggs);

        }
    }
}
