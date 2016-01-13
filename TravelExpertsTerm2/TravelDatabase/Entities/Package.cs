using System;

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
    }
}
