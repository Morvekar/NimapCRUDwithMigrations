using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NimapCRUDwithMigrations.Models
{
    public class Product
    {
        //Since a product belongs to category, CategoryID is declared to be Primary Key
        
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }
    }
}