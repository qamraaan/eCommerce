using ClothBazar.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        
        public CBContext() : base("name=ClothBazarConnection")
        {
            // this.Database.Connection.ConnectionString=""
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catogery> Catogeries { get; set; }

    }
}
