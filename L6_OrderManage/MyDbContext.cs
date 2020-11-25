using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace L6_EFOrderManage
{
    public class MyDbContext : DbContext
    {
        public DbSet<Order> OrderDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("server=localhost;database=test;user=root;password=GYJmysql@0228");
    }
}
