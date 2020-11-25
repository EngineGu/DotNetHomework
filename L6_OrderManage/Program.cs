using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;

namespace L6_EFOrderManage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Service.AddOrder(10, 100, 1000));
            Console.WriteLine(Service.AddOrder(11, 101, 1001));
            Console.WriteLine(Service.AddOrder(12, 102, 1002));
            Console.WriteLine(Service.UpdateOrder(3, 13, 103, 1003));
        }
    }
}
