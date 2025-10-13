using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class Product
    {
        public int ProductID { get; set; } //primary key
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductDesc { get; set; }
        public int StockQuantity { get; set; }
    }
}
