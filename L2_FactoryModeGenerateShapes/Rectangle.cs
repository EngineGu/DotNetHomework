using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_FactoryModeGenerateShapes
{
    class Rectangle:Shape
    {
        private double length;
        private double width;

        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
            if (!Verify())
            {
                throw new ArgumentOutOfRangeException("Invalid Reactangle");
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if(value>0)
                {
                    length = value;
                }
                else
                {
                    
                        throw new ArgumentOutOfRangeException("Invalid Rectangle");
                    
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {

                    throw new ArgumentOutOfRangeException("Invalid Rectangle");

                }
            }
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override bool Verify()
        {
            if (length > 0 && width > 0)
                return true;
            else
                return false;
        }

    }
}
