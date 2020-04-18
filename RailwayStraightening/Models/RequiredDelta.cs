using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStraightening.Models
{
    public class RequiredDelta
    {
        public double Value => negative ? -value : value;
        double value;
        bool negative;

        public RequiredDelta(double difference, double accuracy)
        {
            value = Math.Abs(difference) - accuracy;
            negative = difference < 0;
        }
    }
}
