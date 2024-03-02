using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorWorkings
{
    public partial class VectorCreator : Form
    {
        public VectorDescriptions myReturnVector;
        //accessable only in this form but can be passed to another form or class through parameters
        //public List<VectorDescriptions> vectorDescriptions = new List<VectorDescriptions>();
        public VectorCreator()
        {
            InitializeComponent();
        }

        private void cmdCreateVector_Click(object sender, EventArgs e)
        {
            VectorDescriptions tempVector = new VectorDescriptions(Convert.ToDouble(txtMagnitude.Text), Convert.ToDouble(txtAngle.Text), Convert.ToDouble(txtInitialHeight.Text), Convert.ToDouble(txtInitialRange.Text), txtVectorName.Text);

            //allows the use of functions from another form by opening it as a subspace of form2
            //var callToMainForm = Application.OpenForms.OfType<Form1>().Single();
            //callToMainForm.addToPage(tempVector);
            if (tempVector == null)
                return;

            myReturnVector = tempVector;
            this.Close();


            //this assumes there is at lesat 1 thing in the list
            //VectorDescriptions newVector = vectorDescriptions[0];
            //example 2 lists let you look through them whether this is simething or not
            //looks through a list even if nothing is there
            //foreach (VectorDescriptions oneVector in vectorDescriptions) { }

        }
    }
}
