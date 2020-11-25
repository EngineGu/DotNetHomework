using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using L6_WebApiOrderManage.Models;
using Microsoft.EntityFrameworkCore;

namespace L6_WebApiOrderManage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly OrderDbContext OrderDb;

        public OrderController(OrderDbContext orderdb)
        {
            this.OrderDb = orderdb;
        }

       
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                OrderDb.Orders.Add(order);
                OrderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(long id)
        {
            try
            {
                var order = OrderDb.Orders.FirstOrDefault(t => t.Id == id);
                if (order != null)
                {
                    OrderDb.Orders.Remove(order);
                    OrderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(long id,Order order)
        {
            if(id!=order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderDb.Entry(order).State = EntityState.Modified;
                OrderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if(e.InnerException!=null)
                {
                    error = e.InnerException.Message;
                }
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)
        {
            var FoundOrder = OrderDb.Orders.FirstOrDefault(t => t.Id == id);
            if (FoundOrder == null)
            {
                return NotFound();
            }
            return FoundOrder;
        }
    }
}
