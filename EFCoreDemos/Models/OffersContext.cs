using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemos.Models
{
    public class OffersContext : DbContext
    {
        public OffersContext(DbContextOptions<OffersContext> options) : base(options)
        { }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
