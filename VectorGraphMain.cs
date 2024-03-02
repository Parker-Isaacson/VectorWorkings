using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace VectorWorkings
{
    public partial class VectorGraphMain : Form
    {
        //declarations are like varaibles, methods are private or public funcions, on screen events
        #region Declarations
        public List<VectorDescriptions> vectorDescriptions = new List<VectorDescriptions>();
        public int lines = 0;
        #endregion

        #region Methods
        private double quadraticRoots(double a, double b, double c)
        {
            double sol1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double sol2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            if (sol1 > sol2) { return sol1; }
            else { return sol2; }
        }
        public void addToPage(VectorDescriptions KnownVector)
        {
            vectorDescriptions.Add(KnownVector);
            refreshComboBox();

        }
        private void updateGraph(VectorDescriptions workingVector)
        {
            //random color picker
            Random random = new Random();
            //makes sure the input is unique
            if (chartFunctions.Series.IsUniqueName(workingVector.Name) == false) { return; }

            var objChart = chartFunctions.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //If this is the first line then the maximum x and y values are set to zero and there series is cleared
            if (lines == 0) { objChart.AxisX.Maximum = 0; objChart.AxisY.Maximum = 0; chartFunctions.Series.Clear(); }
            //sets the maximum values if the max of the function is larger than the current max
            if (workingVector.FinalRange > objChart.AxisX.Maximum) { objChart.AxisX.Maximum = workingVector.FinalRange.Round(2); }
            if (workingVector.ApexHeight > objChart.AxisY.Maximum) { objChart.AxisY.Maximum = workingVector.ApexHeight.Round(2); }
            objChart.AxisX.Minimum = 0;
            objChart.AxisY.Minimum = 0;

            //Adds a lines to a series, who is called later with the value that is the number of lines
            chartFunctions.Series.Add($"{workingVector.Name}");
            chartFunctions.Series[lines].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chartFunctions.Series[lines].Legend = "Legend1";
            chartFunctions.Series[lines].ChartArea = "ChartArea1";
            chartFunctions.Series[lines].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            double accuracy = .1D;
            if (workingVector.FinalTime > 1000)
            { accuracy = 10D; }
            else if (workingVector.FinalTime > 100)
            { accuracy = 1D; }

            for (double t = 0; t <= workingVector.FinalTime; t += accuracy)
            {
                chartFunctions.Series[lines].Points.AddXY(workingVector.InitialRange + (workingVector.InitialXVelocity * t), workingVector.InitialHeight + (workingVector.InitialYVelocity * t) - (4.9 * t * t));
            }
            lines++;
        }
        private void refreshComboBox()
        {
            txtOutput.Clear();
            cboVectorListing.Items.Clear();
            for (int i = 0; i < vectorDescriptions.Count; i++)
            {
                cboVectorListing.Items.Add(vectorDescriptions[i]);
            }
        }
        #endregion

        #region On-Screen-Events
        public VectorGraphMain()
        {
            InitializeComponent();
        }
        private void cmdAddVector_Click(object sender, EventArgs e)
        {
            VectorCreator form2 = new VectorCreator();
            // .show() does not keep any of the data after closing, .ShowDialog() does
            form2.ShowDialog();
            //takes the object created from form too and adds it to form 1
            if (form2.myReturnVector == null)
                return;
            addToPage(form2.myReturnVector);
            cboVectorListing.SelectedItem = form2.myReturnVector;
        }
        private void cboVectorListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox myComboBox = sender as ComboBox;
            VectorDescriptions workingVector = myComboBox.SelectedItem as VectorDescriptions;
            txtOutput.Clear();
            txtOutput.Text += $"Name: {workingVector.Name}\r\n{workingVector.initialFunctions()}\r\n{workingVector.apexFunctions()}\r\n{workingVector.finalFunctions()}";
            updateGraph(workingVector);
        }
        private void cmdAddVectors_Click(object sender, EventArgs e)
        {
            VectorDescriptions a = new VectorDescriptions(14, 30, 120, 0, "Baseball");
            VectorDescriptions b = new VectorDescriptions(20, 20, 20, 10, "Rock");
            VectorDescriptions c = new VectorDescriptions(1000, 20, 0, 20, "BB");
            vectorDescriptions.Add(a);
            vectorDescriptions.Add(b);
            vectorDescriptions.Add(c);
            refreshComboBox();
        }
        private void cmdResetChart_Click(object sender, EventArgs e)
        {
            chartFunctions.Series.Clear();
            lines = 0;
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter SavedFile = new StreamWriter("C:\\DevProjects\\VectorWorkings\\SavedData.txt"))
            {
                foreach (VectorDescriptions workingVector in vectorDescriptions)
                {
                    SavedFile.WriteLine($"{workingVector.Name}|{workingVector.Magnitude}|{workingVector.Angle}|{workingVector.InitialHeight}|{workingVector.InitialRange}");
                }
                txtOutput.Text = "Saved";
            }

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //Name|Magnitude|Angle|InitialHeight|InitialRange
            //the class is: vectorDescriptions
            using (StreamReader fileRead = new StreamReader("C:\\DevProjects\\VectorWorkings\\SavedData.txt"))
            {
                string line;
                while ((line = fileRead.ReadLine()) != null)
                {   
                    string[] vectorParts = line.Split('|');
                    VectorDescriptions a = new VectorDescriptions(vectorParts[1].ToDouble(), vectorParts[2].ToDouble(), vectorParts[3].ToDouble(), vectorParts[4].ToDouble(), vectorParts[0]);
                    vectorDescriptions.Add(a);
                }
            }
            refreshComboBox();
            txtOutput.Text = "Loaded";
        }
        private void chartFunctions_MouseMove(object sender, MouseEventArgs e)
        {
            //var sourceChart = sender as Chart;
            //HitTestResult result = sourceChart.HitTest(e.X, e.Y);
            //ChartArea chartAreas = sourceChart.ChartAreas[0];

            //if (result.ChartElementType == ChartElementType.DataPoint)
            //{
            //    chartAreas.CursorX.Position = chartAreas.AxisX.PixelPositionToValue(e.X);
            //    chartAreas.CursorY.Position = chartAreas.AxisY.PixelPositionToValue(e.Y);
            //}
            //txtOutput.Text = $"";

        }

        #endregion
    }
}
