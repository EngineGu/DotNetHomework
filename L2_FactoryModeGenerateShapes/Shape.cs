using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_FactoryModeGenerateShapes
{
    abstract class Shape
    {
         public abstract double GetArea();

         public abstract bool Verify();
                
    }
}
