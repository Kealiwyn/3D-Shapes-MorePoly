using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Shapes_MorePoly
{
    class Cube : Sphere
    {
        public override double Volume { 
            get
            {
                return Math.Pow(Length, 3);
            }
        }

        public Cube(double length) : base(length) { }
    }
}
