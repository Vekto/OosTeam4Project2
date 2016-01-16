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
        private bool _CascadeEnabled;

        /// <summary>
        /// Persist queries and modifications across child entities.
        /// </summary>
        public PackageEntityProvider Cascade { get; }

        #region Constructors

        /// <summary>
        /// Access instance through <see cref="Database.PackageProvider"/>
        /// </summary>
        internal PackageEntityProvider()
        {
            _CascadeEnabled = false;
            Cascade = new PackageEntityProvider(true);
        }

        private PackageEntityProvider(bool cascade)
        {
            _CascadeEnabled = cascade;
            Cascade = this;
        }

        #endregion

        #region EntityProviderBase<Package>

        protected override string TableName => "Packages";

        protected override Package Get(SqlConnection conn, int id)
        {
            // TODO: Lock FluentApi
            //var cascade = _CascadeEnabled;
            //_CascadeEnabled = false; // reset immediately so the setting doesn't persist

            Package package;
            using (var reader = new SqlCommand($"SELECT * FROM {TableName} WHERE PackageId={id}", conn).ExecuteReader())
            {
                if (!reader.Read()) return null;
                package = ParsePackage(reader);
            }

            if (_CascadeEnabled) package.ProductSuppliers.AddRange(GetProductSuppliersRelatedToId(conn, id));
            return package;
        }

        protected override IEnumerable<Package> GetAll(SqlConnection conn)
        {
            //var cascade = _CascadeEnabled;
            //_CascadeEnabled = false; // reset immediately so the setting doesn't persist

            var packages = new List<Package>();

            using (var reader = new SqlCommand($"SELECT * FROM {TableName}", conn).ExecuteReader())
            {
                while (reader.Read()) packages.Add(ParsePackage(reader));
            }

            // ReSharper disable once InvertIf
            if (_CascadeEnabled)
            {
                foreach (var package in packages)
                    package.ProductSuppliers.AddRange(GetProductSuppliersRelatedToId(conn, package.PackageId));
            }
            
            return packages;
        }

        protected override int Add(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
            //var sql = $"INSERT INTO {TableName}";
        }

        protected override bool Delete(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
            // Remove all references to this package in Packages_Products_Suppliers
        }

        protected override bool Update(SqlConnection conn, Package entity)
        {
            throw new NotImplementedException();
            // Remove non-existent references to ProductSuppliers in Packages_Products_Suppliers
            // Add/Update existing references to ProductSuppliers in Packages_Products_Suppliers
        }

        #endregion

        #region Private Methods

        private IEnumerable<ProductSupplier> GetProductSuppliersRelatedToId(SqlConnection conn, int packageId)
        {
            // Select Product_Suppliers where they're linked to this package in Packages_Products_Suppliers 
            var sql = "SELECT ps.ProductSupplierId, p.ProductId, p.ProdName, s.SupplierId, s.SupName" +
                      " FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Products p, Suppliers s" +
                      " WHERE pps.ProductSupplierId=ps.ProductSupplierId AND ps.ProductId=p.ProductId AND ps.SupplierId=s.SupplierId" +
                      $" AND pps.PackageId={packageId}";

            var result = new List<ProductSupplier>();
            using (var reader = new SqlCommand(sql, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(ParseProductSupplier(reader));
                }
            }
            return result;
        }

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