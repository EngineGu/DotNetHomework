using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                for (int i = 2; i <= 100; i++)
                {
                    list.Add(i);
                }

                foreach (int i in list)
                {
                    Console.Write(i + " ");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("error：" + e.Message);
            }

        }

        private static void FilterList(List<int> list)
        {
            for (int factor = 2; factor * factor <= 100; factor++)
            //此处判断条件是factor^2<=100，是因为筛选的关键其实是multiple要全，
            //而factor*side之所以考虑factor就足够了，是因为side相关的multiple会在factor的乘积中获得
            {
                for (int multiple = factor * 2; multiple <= 100; multiple += factor)
                {
                    list.Remove(multiple);
                }
            }
        }
    }
}
