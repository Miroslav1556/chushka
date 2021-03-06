using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA_MG_12D.Data
{
    public class ChuskaContext : DbContext
    {
        public ChuskaContext()
        {

        }
        public ChuskaContext(DbContextOptions<ChuskaContext> options):
            base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }


    }
}
    