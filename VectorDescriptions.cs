using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorWorkings
{
    public class VectorDescriptions
    {
        public const string sup2 = "²";
        public const string oneHalf = "½";
        public double Magnitude, Angle, InitialHeight, InitialRange, InitialXVelocity, InitialYVelocity, ApexHeight, ApexRange, ApexTime, FinalYVelocity, FinalRange, FinalTime;
        public string Name;
        /// <summary>
        /// Constructor for VectorDescriptions
        /// Magnitude, Angle, Intiial Height, Initial Range, Name
        /// </summary>
        /// <param name="input1">Magnitude</param>
        /// <param name="input2">Angle</param>
        /// <param name="input3">Initial Height</param>
        /// <param name="input4">Initial Range</param>
        /// <param name="input5">Name</param>
        public VectorDescriptions(double input1, double input2, double input3, double input4, string input5)
        {
            Magnitude = input1;
            Angle = input2;
            InitialHeight = input3;
            InitialRange = input4;
            Name = input5;
            InitialXVelocity = Magnitude * Math.Cos(Angle.ToRadians());
            InitialYVelocity = Magnitude * Math.Sin(Angle.ToRadians());
            ApexTime = InitialYVelocity / 9.8;
            ApexHeight = InitialHeight + (InitialYVelocity * ApexTime) - (4.9 * ApexTime * ApexTime);
            ApexRange = InitialRange + (InitialXVelocity * ApexTime);
            FinalTime = quadraticFormula(-4.9, InitialYVelocity, InitialHeight);
            FinalYVelocity = InitialYVelocity - 9.8 * FinalTime;
            FinalRange = InitialRange + (InitialXVelocity * FinalTime);
        }
        /// <summary>
        /// returns the x and y functions at the initial position
        /// </summary>
        /// <returns></returns>
        public string initialFunctions()
        {
            return $"Initial:\r\ny = {InitialHeight.Round(3)} + {InitialYVelocity.Round(3)}t + {oneHalf}(-9.8)t{sup2}\r\nx = {InitialRange.Round(3)} + {InitialXVelocity.Round(3)}t";
        }
        /// <summary>
        /// returns the x and y functions along with the time at the apex position
        /// </summary>
        /// <returns></returns>
        public string apexFunctions()
        {
            return $"Apex: {ApexTime.Round(3)}s\r\ny = {ApexHeight.Round(3)} + {oneHalf}(-9.8)t{sup2}\r\nx = {ApexRange.Round(3)} + {InitialXVelocity.Round(3)}t";
        }
        /// <summary>
        /// returns the x and y functions along with the time at the final position
        /// </summary>
        /// <returns></returns>
        public string finalFunctions()
        {
            return $"Final: {FinalTime.Round(3)}s\r\ny = {FinalYVelocity.Round(3)}t + {oneHalf}(-9.8)t{sup2}\r\nx = {FinalRange.Round(3)} + {InitialXVelocity.Round(3)}t";
        }

        /// <summary>
        /// Formal Display Name For the combo box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        //used internally to calculate the root of any quadratic function
        private double quadraticFormula(double a, double b, double c)
        {
            double sol1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double sol2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            if (sol1 > sol2) { return sol1; }
            else { return sol2; }
        }
    }
}
