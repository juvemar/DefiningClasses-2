using System;

namespace Point
{
    public static class Distance
    {
        public static double TwoPointsDistance(Point3D first, Point3D second)
        {
            double distanceX = (first.X - second.X) * (first.X - second.X);
            double distanceY = (first.Y - second.Y) * (first.Y - second.Y);
            double distanceZ = (first.Z - second.Z) * (first.Z - second.Z);
            return Math.Sqrt(distanceX + distanceY + distanceZ);
        }
    }
}