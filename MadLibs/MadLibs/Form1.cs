using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color;
            string wordEst;
            string bodyPart;
            string animal;
            string noun1;
            string nounPlural;
            int num1;
            int num2;
            int num3;

            color = Convert.ToString(txtcolor.Text);
            wordEst = Convert.ToString(txtword.Text);
            bodyPart = Convert.ToString(txtbodypart.Text);
            animal = Convert.ToString(txtanimal.Text);
            noun1 = Convert.ToString(txtnoun.Text);
            nounPlural = Convert.ToString(txtnounplural.Text);
            num1 = Convert.ToInt32(txtnum1.Text);
            num2 = Convert.ToInt32(txtnum2); 

            num3 = num1 - num2;

            lblstory.Text = String.Format("The {0} Dragon is the {1} Dragon of all. It " +
                "has {2} {3}, and a {4} shaped like a {5}. It loves to eat {6}, although it " +
                "will feast on nearly anything.", color, wordEst, num3, bodyPart, animal, noun1,
                nounPlural); 









        }
    }
}
