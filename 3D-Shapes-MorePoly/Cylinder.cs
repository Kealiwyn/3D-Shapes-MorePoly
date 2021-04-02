using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Shapes_MorePoly
{
    class Cylinder : Sphere
    {
        public double Height { get; private set; }
        public override double Volume {
            get
            {
                return (double)Math.PI * Math.Pow(Length / 2, 2) * Height;
            }
        }

        public Cylinder(double length, double height) : base(length)
        {
            Height = height;
        }
    }
}
