using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Shape
{
    class Circle:Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            if (!Verify())
            {
                throw new ArgumentOutOfRangeException("Invalid Circle");
            }
        }

        public double Radius
        {
            get
            {
               return radius;
            }
            set
            {
                radius = value;
                if(!Verify())
                {
                    throw new ArgumentOutOfRangeException("Invalid Circle");
                }
            }
        }

        public override double GetArea()
        {
           
            return Math.PI * radius * radius;
        }

        public override bool Verify()
        {
            if (radius > 0)
                return true;
            else
                return false;
        }
    }
}
