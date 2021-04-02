using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Shapes_MorePoly
{
    class Sphere
    {
        public double Length { get; set; }
        public virtual double Volume {
            get
            {
                return (double)Math.PI * 4 / 3 * Math.Pow(Length / 2, 3);
            }
        }

        public Sphere(double length)
        {
            Length = length;
        }

        public double GetMass(double density)
        {
            return density * Volume;
        }
    }
}
