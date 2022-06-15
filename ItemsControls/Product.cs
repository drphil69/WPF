using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControls
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool ProductExpired { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableProducts { get; set; }
    }
}
