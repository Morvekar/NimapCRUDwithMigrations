using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NimapCRUDwithMigrations.Models
{
    public class Services:DbContext
    {
        public DbSet<Product> Products { get; set; }
        
    }
}