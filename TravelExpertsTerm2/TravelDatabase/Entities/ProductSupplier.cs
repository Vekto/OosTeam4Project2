using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase
{
    public class ProductSupplier
    {
        public int ProductSupplierID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
    }
}
