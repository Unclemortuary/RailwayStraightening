using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStraightening.Models
{
    public class Point
    {
        public double Etalon { get; private set; }
        public double Value { get; private set; }
        public int Index { get; private set; }

        // maybe Accuracy should be a field
        public bool Inacurate(double accuracy)
        {
            return Math.Abs(Value - Etalon) > accuracy;
        }

        public void ChangeValue(RequiredDelta delta)
        {
            Value = Value + delta.Value;
        }

        public void ApplyAffectFromNeigborPoint(RequiredDelta delta)
        {
            Value = Value + delta.Value / 2;
        }

        public RequiredDelta GetRequiredDelta(double accuracy)
        {
            var difference = Etalon - Value;
            return new RequiredDelta(difference, accuracy);
        }

        public Point(double etalon, double value, int index)
        {
            Etalon = etalon;
            Value = value;
            Index = index;
        }
    }
}
