using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase
{
    public class Package
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Commission { get; set; }
        public List<ProductSupplier> products { get; set; }
    }
}
