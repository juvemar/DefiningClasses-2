using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.Sequence = new List<Point3D>();
        }

        public List<Point3D> Sequence { get; set; }

        public void AddingPoints(Point3D point)
        {
            Sequence.Add(point);
        }
    }
}
