// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;

namespace TravelDatabase
{
    [Devin]
    public class Package
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public decimal AgencyCommission { get; set; }

        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
