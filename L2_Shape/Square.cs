using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Shape
{
    class Square:Rectangle
    {
        public Square(double length) : base(length, length)
        {
            if(!Verify())
            {
                throw new ArgumentOutOfRangeException("Invalid Square!");
            }

        }

        public new double Length
        {
            get { return base.Length; }
            set
            {
                base.Length = value;
                base.Width = value;
                if(!Verify())
                {
                    throw new ArgumentOutOfRangeException("Invalid Square!");
                }
            }
        }

        //自动继承了Rectangle的GetArea()

        public override bool Verify()
        {
            if (Length > 0 && Width > 0 && Length == Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
