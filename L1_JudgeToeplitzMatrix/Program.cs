using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudgeToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
               {
                {1,2,3,4 },
                {5,1,2,3 },
                {9,5,1,2 }
            };
            Console.WriteLine("结果是：" + IsToeplitzMatrix(matrix));
        }

        private static bool IsToeplitzMatrix(int[,] matrix)
        {
            bool flag = true;
            for (int i = 1; i < matrix.GetLength(0) && flag; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) && flag; j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1])//?matrix[][]报错了？a[,,,]是多维数组，是个矩阵，但是a[][][]是个交错数组，每维的长度不统一
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
    }


}

