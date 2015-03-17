using System;
using System.IO;
using System.Linq;

namespace Point
{
    public static class PathStorage
    {
        public static void SavePaths(Path path, string folderName)
        {
            using (StreamWriter saver = new StreamWriter("../../path" + folderName + ".txt"))
            {
                foreach (var item in path.Sequence)
                {
                    saver.WriteLine(item);
                }
            }
        }

        public static Path LoadPaths(string filePath)
        {
            Path loaded = new Path();
            StreamReader loader = new StreamReader(filePath);
            using (loader)
            {
                string current = loader.ReadLine();
                while (current != null)
                {
                    double[] coords = current.Split(new char[] { ' ' }).Select(double.Parse).ToArray();
                    loaded.AddingPoints(new Point3D(coords[0], coords[1], coords[2]));

                    current = loader.ReadLine();
                }
            }

            return loaded;
        }
    }
}
