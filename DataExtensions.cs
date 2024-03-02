using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorWorkings
{
    public static class DataExtensions
    {
        /*
         *for Future refernce:
         *This is rather complex, we madea public function that retunrs a double, (dont worry about static I will talk about it later
         *the function converts degrees to radians and can be used as a .toRadians on the end of a assigned double variable in 
         *its paramater "this double hobo" states that hobo is a double that is part of the double class and can be used to edit 
         *the static part of the first bit is used to denoted that there is only one of this function and that it can be accessed from anyware in the program 
         */
        public static double ToRadians(this double hobo)
        {
            return hobo * Math.PI / 180D;
        }
        public static float ToRadians(this int hobo)
        {
            // the word (float) is a cast.
            return hobo * ((float) Math.PI) / 180F;
        }
        public static double ToDegrees(this double hobo)
        {
            return hobo * 180D / Math.PI;
        }
        public static float ToDegrees(this float hobo)
        {
            return hobo * 180F / ((float) Math.PI);
        }
        public static double Round(this double hobo, int R)
        {
            return Math.Round(hobo,R);
        }
        public static float Round(this float hobo, int R)
        {
            return (float) Math.Round(hobo, R);
        }
        public static double ToDouble(this string hobo)
        {
            return Convert.ToDouble(hobo);
        }
    }
}
