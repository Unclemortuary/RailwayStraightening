using RailwayStraightening.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwayStraightening
{
    public class Data
    {
        public double Accuracy { get; private set; }
        public Point[] Points { get; private set; }

        public Data(double[] etalon, double[] measured, double accuracy)
        {
            // change this initialization
            var points = new List<Point>();
            for (int i = 0; i < etalon.Length; i++)
            {
                points.Add(new Point(etalon[i], measured[i], i));
            }

            Points = points.ToArray();
            Accuracy = accuracy;
        }

        public void Calculate()
        {
            // smells strange - need to find another place/way for this
            var result = new Point[Points.Length];
            Array.Copy(Points, result, Points.Length);

            while (result.Any(p => p.Inacurate(Accuracy)))
            {
                foreach (var point in Points)
                {
                    if (point.Inacurate(Accuracy))
                    {
                        var requiredDelta = point.GetRequiredDelta(Accuracy);
                        point.ChangeValue(requiredDelta);
                        ApplyChangesToNeighbors(point.Index, requiredDelta);
                    }
                }
            }
        }

        private void ApplyChangesToNeighbors(int index, RequiredDelta delta)
        {
            // left side point
            if (index != 0)
                Points[index - 1].ApplyAffectFromNeigborPoint(delta);
            // right side point
            if (index != Points.Length - 1)
                Points[index + 1].ApplyAffectFromNeigborPoint(delta);
        }
    }
}
