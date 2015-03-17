
namespace Point
{
    public struct Point3D
    {
        private static readonly Point3D o;

        private double x;
        private double y;
        private double z;

        public Point3D(double xCoord, double yCoord, double zCoord)
            : this()
        {
            this.x = xCoord;
            this.y = yCoord;
            this.z = zCoord;
        }

        static Point3D()
        {
            o = new Point3D(0, 0, 0);
        }

        public static Point3D O
        {
            get { return o; }
        }
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }
    }
}
