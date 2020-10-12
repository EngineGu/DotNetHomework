using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L2_FactoryModeGenerateShapes
{
    class ShapeFactory
    {

        static Random random = new Random();
        public static Shape GenerateShape(string type, double[] edges)
        {
            switch(type)
            {
                case "triangle":return new Triangle(edges[0], edges[1], edges[2]);
                case "rectangle":return new Rectangle(edges[0], edges[1]);
                case "square": return new Square(edges[0]);
                case "circle": return new Circle(edges[0]);
                default: throw new ArgumentOutOfRangeException("Invalid type:" + type);

            }
        }

        
        public static Shape GenerateRandomShapes()
        {
            // int type = random.Next(0, 4);
            int type = 0;
            switch(type)
            {
                case 0:
                    Shape t = GenerateShape("triangle", new double[] { random.NextDouble() * 100, random.NextDouble() * 100, random.NextDouble() * 100 });
                    while(!t.Verify())
                    {
                        t = GenerateShape("triangle", new double[] { random.NextDouble() * 100, random.NextDouble() * 100, random.NextDouble() * 100 });
                    }
                    return t;
                case 1:
                    Shape r= GenerateShape("rectangle", new double[] { random.NextDouble() * 100, random.NextDouble() * 100 });
                    while (!r.Verify())
                    {
                        r = GenerateShape("rectangle", new double[] { random.NextDouble() * 100, random.NextDouble() * 100 });
                    }
                    return r;
                case 2:
                    Shape s= GenerateShape("square", new double[] { random.NextDouble() * 100 });
                    while (!s.Verify())
                    {
                        s = GenerateShape("square", new double[] { random.NextDouble() * 100 });
                    }
                    return s;
                case 3:
                    Shape c = GenerateShape("circle", new double[] { random.NextDouble() * 100 });
                    while (!c.Verify())
                    {
                        c = GenerateShape("circle", new double[] { random.NextDouble() * 100 });
                    }
                    return c;
                default:throw new ArgumentOutOfRangeException("Invalid type number:" + type);
            }


        }
        
    }
}
