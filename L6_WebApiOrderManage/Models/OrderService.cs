using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;


namespace L6_WebApiOrderManage.Models
{
    public class OrderService
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="customer_id">顾客编号</param>
        /// <param name="good_id">商品编号</param>
        /// <param name="good_amount">商品数量</param>
        /// <returns></returns>
        public static string AddOrder(long customer_id, long good_id, double good_amount)
        {
            using (var db = new OrderDbContext())
            {
                Order order = new Order() { Customer_Id = customer_id, Good_Id = good_id, Good_Amount = good_amount };
                db.Add(order);
                db.SaveChanges();
                return JsonConvert.SerializeObject(order, Formatting.Indented);
            }
        }
        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <returns></returns>
        public static string RemoveOrder(long id)
        {
            using (var db = new OrderDbContext())
            {
                var obj = db.Orders.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
        /// <summary>
        /// 修改订单
        /// </summary>
        /// <param name="id">旧的订单号</param>
        /// <param name="customer_id_new">新的顾客编号</param>
        /// <param name="good_id_new">新的货物编号</param>
        /// <param name="good_amount_new">新的货物数量</param>
        /// <returns></returns>
        public static string UpdateOrder(long id, long customer_id_new, long good_id_new, double good_amount_new)
        {
            using (var db = new OrderDbContext())
            {
                var obj = db.Orders.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                obj.Customer_Id = customer_id_new;
                obj.Good_Id = good_id_new;
                obj.Good_Amount = good_amount_new;
                db.Add(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <returns></returns>
        public static string QueryOrder(long id)
        {
            using (var db = new OrderDbContext())
            {
                var obj = db.Orders.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "no such order";
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
       
    }
}
