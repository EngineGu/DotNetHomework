using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入左操作数：");
            double leftOperand = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入右操作数：");
            double rightOperand = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            char myOperator = Console.ReadLine()[0];
            double result = 0.0;
            switch (myOperator)
            {
                case '+': result = leftOperand + rightOperand; break;
                case '-': result = leftOperand - rightOperand; break;
                case '*': result = leftOperand * rightOperand; break;
                case '/': result = leftOperand / rightOperand; break;
                case '%': result = leftOperand % rightOperand; break;
                default: Console.WriteLine("请输入正确的运算符："); break;
            }
            Console.WriteLine($"结果为{result}");
        }
    }
}
