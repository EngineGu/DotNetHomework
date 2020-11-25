using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;

namespace L6_EFOrderManage
{
    class Service
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="customer_id">顾客编号</param>
        /// <param name="good_id">商品编号</param>
        /// <param name="amount">商品数量</param>
        /// <returns></returns>
        public static string AddOrder(long customer_id, long good_id, double amount)
        {
            using (var db = new MyDbContext())
            {
                Order order = new Order() { Customer_Id = customer_id, Good_Id = good_id, Good_Amount = amount };
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
            using (var db = new MyDbContext())
            {
                var obj = db.OrderDb.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
        /// <summary>
        /// 更改订单
        /// </summary>
        /// <param name="id">原订单编号</param>
        /// <param name="customer_id_new">新顾客编号</param>
        /// <param name="good_id_new">新商品编号</param>
        /// <param name="amount_new">新商品数量</param>
        /// <returns></returns>
        public static string UpdateOrder(long id, long customer_id_new, long good_id_new, double amount_new)
        {
            using (var db = new MyDbContext())
            {
                var obj = db.OrderDb.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                obj.Customer_Id = customer_id_new;
                obj.Good_Id = good_id_new;
                obj.Good_Amount = amount_new;
                db.Add(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
        /// <summary>
        /// 查找订单
        /// </summary>
        /// <param name="id">订单编号</param>
        /// <returns></returns>
        public static string QueryOrder(long id)
        {
            using (var db = new MyDbContext())
            {
                var obj = db.OrderDb.Where(x => x.Id == id).FirstOrDefault();
                if (obj == null) return "no such order";
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
       
    }
}
