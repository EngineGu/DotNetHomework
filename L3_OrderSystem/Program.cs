using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Customer customer1 = new Customer(1, "GYJ");
                Customer customer2 = new Customer(2, "SYY");

                Good Dior = new Good(1, "Dior", 330.5f);
                Good Chanel = new Good(2, "Chanel", 220.6f);
                Good TF = new Good(3, "TF", 500.3f);

                Order order1 = new Order(1, customer1);
                order1.AddPurchase(new Purchase(Dior, 40));
                order1.AddPurchase(new Purchase(Chanel, 80));
                order1.AddPurchase(new Purchase(TF, 50));


                Order order2 = new Order(2, customer2);
                order2.AddPurchase(new Purchase(Dior, 40));
                order2.AddPurchase(new Purchase(TF, 50));

                Order order3 = new Order(3, customer1);
                order3.AddPurchase(new Purchase(Dior, 450));

                OrdersTable orderTable = new OrdersTable();
                orderTable.AddOrder(order1);
                orderTable.AddOrder(order2);
                orderTable.AddOrder(order3);

                Console.WriteLine("\nQueryAll");
                List<Order> orders = orderTable.QueryAll();
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nQueryByCustomerName");
                orders = orderTable.QueryByCustomerName("SYY");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nQueryByGoodName");
                orders = orderTable.QueryByGoodName("TF");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nQueryByTotalAmount");
                orders = orderTable.QueryByTotalAmount(20000);
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nRemove order2");

                orderTable.RemoveOrder(orderTable.GetOrder(2));
                orderTable.QueryAll().ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\n order by Amount");
                orderTable.Sort((o1, o2) => o2.TotalAmount.CompareTo(o1.TotalAmount));
                orderTable.QueryAll().ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\n export and import");
                orderTable.Export(@".\test.xml");
                List<Order> importedOrders = orderTable.Import(@".\test.xml");
                importedOrders.ForEach(o => Console.WriteLine(o));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

}

