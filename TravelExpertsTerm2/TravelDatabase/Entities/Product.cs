// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01
using JetBrains.Annotations;

namespace TravelDatabase
{
    /// <remarks>
    /// This class is only used in unit tests. 
    /// It should be replaced by a dummy DB table that's never modified,
    /// and this class shold go away.
    /// </remarks>>
    [Devin]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }
}