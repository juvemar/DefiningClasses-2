using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Point
{
    public class StructureMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D first = new Point3D(2.4, 2.3, 2.5);
            Point3D second = new Point3D(1.4, 0.3, 3.1);
            Point3D third = new Point3D(4.3, -0.1, -2.2);
            Point3D fourth = new Point3D(-2.9, 0, 1.1);

            Path pathTester = new Path();

            pathTester.AddingPoints(first);
            pathTester.AddingPoints(second);
            pathTester.AddingPoints(third);
            pathTester.AddingPoints(fourth);

            PathStorage.SavePaths(pathTester, "test");

            Path loadedPath = PathStorage.LoadPaths(@"../../pathtest.txt");

            for (int i = 0; i < loadedPath.Sequence.Count; i++)
            {
                int numPoint = i + 1;
                Console.WriteLine("Point {0}:", numPoint);
                Console.WriteLine(loadedPath.Sequence[i]);//coordinates of loaded points
            }

            Console.WriteLine("The distance between points 1 and 2 is " + Distance.TwoPointsDistance(first, second));
        }
    }
}
