// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using JetBrains.Annotations;
using TravelDatabase;
using Xunit;

// ReSharper disable MemberCanBePrivate.Global
namespace Test
{
    [Devin]
    [NoReorder]
    public class ProductEntityProviderTests : IEqualityComparer<Product>
    {
        [Fact]
        public void GetEntities()
        {
            Assert.Equal(_AllProducts, Database.ProductProvider.GetEntities(), this);
        }

        [Theory]
        [MemberData(nameof(AllProductsTestData))]
        public void GetEntityById(Product product)
        {
            Assert.Equal(product, Database.ProductProvider.GetEntityById(product.ProductId), this);
        }

        [Fact]
        public void AddThenDeleteEntity()
        {
            var product = new Product
            {
                ProductId = LastAddedIdentity() + 1, // next ID
                Name = "TEST_OBJECT"
            };

            Assert.Null(Database.ProductProvider.GetEntityById(product.ProductId)); // check doesn't exist
            Assert.Equal(product.ProductId, Database.ProductProvider.AddEntity(product)); // add returns new ID
            Assert.Equal(product, Database.ProductProvider.GetEntityById(product.ProductId), this); // check does exist
            Assert.True(Database.ProductProvider.DeleteEntity(product)); // delete returns success
            Assert.Null(Database.ProductProvider.GetEntityById(product.ProductId));// check doesn't exist
        }

        [Theory]
        [MemberData(nameof(AllProductsTestData))]
        public void UpdateEntity(Product product)
        {
            var modified = new Product
            {
                ProductId = product.ProductId,
                Name = "FISH"
            };

            // Set to FISH
            Assert.True(Database.ProductProvider.UpdateEntity(modified));
            Assert.Equal(modified, Database.ProductProvider.GetEntityById(modified.ProductId), this);

            // Set to original value
            Assert.True(Database.ProductProvider.UpdateEntity(product));
            Assert.Equal(product, Database.ProductProvider.GetEntityById(product.ProductId), this);
        }

        private int LastAddedIdentity()
        {
            if (Database.ConnectionString == null) throw new InvalidOperationException($"{nameof(Database.ConnectionString)} is null");
            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                using (var command = new SqlCommand("SELECT IDENT_CURRENT('Products')", conn))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        #region Test Data

        public static IEnumerable<object[]> AllProductsTestData
            => _AllProducts.Select(product => new object[] {product});

        // This table is used to test EntityProviderBase because it's small and never changes
        private static readonly List<Product> _AllProducts
            = new List<Product>
            {
                new Product {ProductId = 1, Name = "Air"},
                new Product {ProductId = 2, Name = "Attractions"},
                new Product {ProductId = 3, Name = "Car rental"},
                new Product {ProductId = 4, Name = "Cruise"},
                new Product {ProductId = 5, Name = "Hotel"},
                new Product {ProductId = 6, Name = "Motor Coach"},
                new Product {ProductId = 7, Name = "Railroad"},
                new Product {ProductId = 8, Name = "Tours"},
                new Product {ProductId = 9, Name = "Travel Insurance"},
                new Product {ProductId = 10, Name = "Yacht/Boat Charters"}
            };

        #endregion

        #region IEqualityComparer<Product>

        public bool Equals(Product x, Product y)
        {
            return x.ProductId == y.ProductId && x.Name == y.Name;
        }

        public int GetHashCode(Product obj)
        {
            return obj.Name.GetHashCode() ^ obj.ProductId.GetHashCode();
        }

        #endregion

    }
}
