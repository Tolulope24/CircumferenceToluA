using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceToluA
{
    public partial class frmCircumferenceOfACircle : Form
    {
        public frmCircumferenceOfACircle()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Identify the consants
            double Radius, Circumference ;
            // Convert the radius into a text box
            Radius = double.Parse(txtRadius.Text);
            Circumference = Radius * Math.PI * 2;
            // convert the Circumference to a label
            lblAnswer.Text = "The Circumference is: "+Convert.ToString(Circumference) + " Cm";
                 
        }
    }
}
