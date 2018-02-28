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
            double Radius;
            Radius = double.Parse(txtRadius.Text);
            lblAnswer.Text;
                 
        }
    }
}
