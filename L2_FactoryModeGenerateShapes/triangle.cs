using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_FactoryModeGenerateShapes
{
    class Triangle:Shape
    {
        private double[] edges = new double[3];

        public Triangle(double a,double b,double c)
        {
            double[] edges = new double[3] { a, b, c };
            this.edges = edges;
        }

        public double[] Edges
        {
            get
            {
                return edges;
            }
            set
            {
                edges = value;
                if(!Verify())
                {
                    throw new ArgumentOutOfRangeException("Invalid Triangle");
                }
            }

        }

        public override double GetArea()
        {
            double p = (edges[0] + edges[1] + edges[2]) / 2;
            double area = Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
            return area;
        }

        public override bool Verify()
        {
            double a = edges[0];
            double b = edges[1];
            double c = edges[2];
            if(a>0&&b>0&&c>0&&a+b>c&&b+c>a&&a+c>b)
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
