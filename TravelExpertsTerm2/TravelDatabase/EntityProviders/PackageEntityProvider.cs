// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [PublicAPI]
    public sealed class PackageEntityProvider : EntityProviderBase<Package>
    {
        // public RemovePackageProvider (delete where packageid & productsupplierid

        /// <summary>
        /// Access instance through <see cref="Database.PackageProvider"/>
        /// </summary>
        internal PackageEntityProvider()
        {
        }

        #region EntityProviderBase<Package>

        protected override string TableName => "Packages";

        protected override Package Get(SqlConnection conn, int id)
        {
            Package package;
            using (var reader = new SqlCommand($"SELECT * FROM Packages WHERE PackageId={id}", conn).ExecuteReader())
            {
                if (!reader.Read()) return null;
                package = ParsePackage(reader);
            }

            // Select Product_Suppliers where they're linked to this package in Packages_Products_Suppliers 
            var sql = "SELECT ps.ProductSupplierId, p.ProductId, p.ProdName, s.SupplierId, s.SupName" +
                      " FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Products p, Suppliers s" +
                      " WHERE pps.ProductSupplierId=ps.ProductSupplierId AND ps.ProductId=p.ProductId AND ps.SupplierId=s.SupplierId" +
                      $" AND pps.PackageId={id}";

            using (var reader = new SqlCommand(sql, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    package.ProductSuppliers.Add(ParseProductSupplier(reader));
                }
            }

            return package;
        }

        protected override IEnumerable<Package> GetAll(SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        protected override int Add(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
        }

        protected override bool Delete(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
        }

        protected override bool Update(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private static Package ParsePackage(SqlDataReader reader)
        {
            return new Package
            {
                PackageId = reader.GetInt32(0),
                Name = reader.GetString(1),
                StartDate = reader.GetDateTime(2),
                EndDate = reader.GetDateTime(3),
                Description = reader.GetString(4),
                BasePrice = reader.GetDecimal(5),
                AgencyCommission = reader.GetDecimal(6)
            };
        }

        private static ProductSupplier ParseProductSupplier(SqlDataReader reader)
        {
            return new ProductSupplier
            {
                ProductSupplierId = reader.GetInt32(0),
                Product = new Product
                {
                    ProductId = reader.GetInt32(1),
                    Name = reader.GetString(2)
                },
                Supplier = new Supplier()
                {
                    SupplierId = reader.GetInt32(3),
                    Name = reader.GetString(4)
                }
            };
        }

        #endregion

    }
}