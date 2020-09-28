using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        //将输入输出和处理模块分开
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an int:");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> PrimeFactors = new List<int>();
            PrimeFactors = GetPrimeFactors(num);
            Console.Write("its prime factors is: ");
            foreach (int factor in PrimeFactors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();
        }

        //要加static修饰。如果不加static需要创建一个Program类的实例对象，才能调用类中的函数。
        private static List<int> GetPrimeFactors(int i_num)
        {
            List<int> PrimeFactors = new List<int>();

            for (int factor = 2; factor * factor <= i_num; factor++)//遍历所有因数
            {
                //用当前因数把i_num除尽，致i_num失去所有当前因数
                //由于当前因数是从小往大变化的，当当前因数为非质数因数时
                //会因为i_num的质数因数被除尽了而在while条件中退出来，让导出的因数必然是质数
                //相当于“埃式筛法”的逆向利用，
                while (i_num % factor == 0)
                {
                    PrimeFactors.Add(factor);
                    i_num = i_num / factor;
                }
            }
            //余下的那个因数加入列表
            if (i_num != 1)
            {
                PrimeFactors.Add(i_num);
            }

            return PrimeFactors;

        }

    }
}
