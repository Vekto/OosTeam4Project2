// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System.Collections.Generic;
using JetBrains.Annotations;

namespace TravelDatabase
{
    [Devin]
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}