using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L6_WebApiOrderManage.Models
{
    public class Order
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public long Good_Id { get; set; }

        /// <summary>
        /// 顾客编号
        /// </summary>
        public long Customer_Id { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public double Good_Amount { get; set; }

    }
}
