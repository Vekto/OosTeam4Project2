// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Linq;
using TravelDatabase;
using Xunit;

namespace Test
{
    public class PackageEntityProviderTests : DatabaseTestingBase, IEqualityComparer<Package>
    {

        #region Tests

        [Theory]
        [MemberData(nameof(SomePackages))]
        public void GetById(Package expected)
        {
            var actual = Database.PackageProvider.GetEntityById(expected.PackageId);
            Assert.Equal(expected, actual, this);
        }

        #endregion

        #region Test Data

        // ReSharper disable once MemberCanBePrivate.Global
        public static IEnumerable<object[]> SomePackages
        {
            get
            {
                yield return new object[]
                {


                    new Package
                    {
                        PackageId = 3,
                        Name = "Asian Expedition",
                        StartDate = DateTime.Parse("2006-05-14 00:00:00.000"),
                        EndDate = DateTime.Parse("2006-05-28 00:00:00.000"),
                        Description = "Airfaire, Hotel and Eco Tour.",
                        BasePrice = 2800M,
                        AgencyCommission = 300M,
                        ProductSuppliers =
                        {
                            new ProductSupplier
                            {
                                ProductSupplierId = 28,
                                Product = new Product {ProductId = 8, Name = "Tours"},
                                Supplier = new Supplier {SupplierId = 8089, Name = "EXCLUSIVE TOURS"}
                            },
                            new ProductSupplier
                            {
                                ProductSupplierId = 82,
                                Product = new Product {ProductId = 5, Name = "Hotel"},
                                Supplier = new Supplier {SupplierId = 9766, Name = "KINTETSU INTERNATIONAL"}
                            },
                            new ProductSupplier
                            {
                                ProductSupplierId = 87,
                                Product = new Product {ProductId = 1, Name = "Air"},
                                Supplier = new Supplier {SupplierId = 1859, Name = "LOTUS HOLIDAYS"}
                            }
                        }
                    }
                };
            }
        }

        #endregion

        #region IEqualityComparer<Package>

        bool IEqualityComparer<Package>.Equals(Package x, Package y)
        {
            if (!(
                x.PackageId == y.PackageId
                && x.Name == y.Name
                && x.StartDate == y.StartDate
                && x.EndDate == y.EndDate
                && x.Description == y.Description
                && x.BasePrice == y.BasePrice
                && x.AgencyCommission == y.AgencyCommission
                && x.ProductSuppliers.Count == y.ProductSuppliers.Count))
                return false;

            // Look for some ProductSupplier where not all fields in x equal
            // all fields in y. If none are found, both sequences are equal.
            return !x.ProductSuppliers.Where((t, i) => !(
                t.ProductSupplierId == y.ProductSuppliers[i].ProductSupplierId 
                && t.Product?.ProductId == y.ProductSuppliers[i].Product?.ProductId 
                && t.Product?.Name == y.ProductSuppliers[i].Product?.Name 
                && t.Supplier?.SupplierId == y.ProductSuppliers[i].Supplier?.SupplierId 
                && t.Supplier?.Name == y.ProductSuppliers[i].Supplier?.Name))
                .Any();
        }

        int IEqualityComparer<Package>.GetHashCode(Package obj)
        {
            return obj.PackageId.GetHashCode();
        }

        #endregion

    }
}
