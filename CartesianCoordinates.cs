using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (points == null)
                throw new ArgumentNullException();
            if (range <= 0)
                throw new ArgumentException();

            List<Point> Neighbors = new List<Point>();
            foreach (Point neighbor in points)
            {
                if (Math.Abs(neighbor.X-point.X)<=range && Math.Abs(neighbor.Y - point.Y) <= range)
                {
                    Neighbors.Add(neighbor);
                }
            }
            return Neighbors;
        }
    }
}