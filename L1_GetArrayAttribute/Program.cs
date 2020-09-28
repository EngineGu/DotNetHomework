using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArrayAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //差错控制
            try
            {
                double[] num = { 0.875, 1.0, 2.0, 3.0, 4.0, 5.2, 6.3, 7.4, 8.5, 9.3 };
                //输出型形参的使用
                GetArrayMaxMinAverSum(num, out double max, out double min, out double sum, out double average);
                Console.WriteLine($"max={max},min={min},sum={sum},average={average}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }

        }

        private static void GetArrayMaxMinAverSum(double[] num, out double max, out double min, out double sum, out double average)
        {

            max = num[0];
            min = num[0];
            sum = 0.0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
                sum += num[i];
            }
            average = sum / num.Length;

        }
    }
}
