using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStraightening
{
    public class Data
    {
        public double Accuracy { get; private set; }
        public double[] Standart { get; private set; }
        public double[] Measured { get; private set; }
        public double[] Calculated { get; private set; }

        public Data(double[] standart, double[] measured, double accuracy, int pointsCount)
        {
            Standart = standart;
            Measured = measured;
            Accuracy = accuracy;
            Calculated = new double[pointsCount];
        }
    }
}
