using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L6_EFOrderManage
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
        /// 客户编号
        /// </summary>
        public long Customer_Id { get; set; }

        /// <summary>
        /// 货物数量
        /// </summary>
        public double Good_Amount { get; set; }
    }
}
