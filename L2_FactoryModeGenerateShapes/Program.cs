using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_FactoryModeGenerateShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                double area = 0.0;
                for(int i=0; i<10;i++)
                {
                    shapes.Add(ShapeFactory.GenerateRandomShapes());
                }
                for(int i=0;i<10;i++)
                {
                    area += shapes[i].GetArea();
                }
                Console.WriteLine("总面积为:"+area);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
