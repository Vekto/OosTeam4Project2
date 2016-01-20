// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [Devin]
    [PublicAPI]
    public sealed class PackageEntityProvider : EntityProviderBase<Package>
    {

        #region Constructors

        /// <summary>
        /// Access instance through <see cref="Database.Packages"/>
        /// </summary>
        internal PackageEntityProvider()
        {
        }

        #endregion

        #region Public Methods

        public IEnumerable<Package> GetEntitiesWithChildren()
        {
            using (var conn = Database.GetConnection())
            {
                var packages = new List<Package>();

                conn.Open();
                using (var reader = new SqlCommand($"SELECT * FROM {TableName}", conn).ExecuteReader())
                {
                    while (reader.Read()) packages.Add(ParsePackage(reader));
                }

                foreach (var package in packages)
                {
                    package.ProductSuppliers.AddRange(GetProductSuppliersRelatedToId(conn, package.PackageId));
                }

                return packages;
            }
        }

        public Package GetEntityByIdWithChildren(int id)
        {
            using (var conn = Database.GetConnection())
            {
                Package package;
                conn.Open();
                using (var reader = new SqlCommand($"SELECT * FROM {TableName} WHERE PackageId={id}", conn).ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    package = ParsePackage(reader);
                }

                package.ProductSuppliers.AddRange(GetProductSuppliersRelatedToId(conn, id));
                return package;
            }
        }

        #endregion

        #region EntityProviderBase<Package>

        protected override string TableName => "Packages";

        protected override Package Get(SqlConnection conn, int id)
        {
            Package package;
            using (var reader = new SqlCommand($"SELECT * FROM {TableName} WHERE PackageId={id}", conn).ExecuteReader())
            {
                if (!reader.Read()) return null;
                package = ParsePackage(reader);
            }
            return package;
        }

        protected override IEnumerable<Package> GetAll(SqlConnection conn)
        {
            var packages = new List<Package>();

            using (var reader = new SqlCommand($"SELECT * FROM {TableName}", conn).ExecuteReader())
            {
                while (reader.Read()) packages.Add(ParsePackage(reader));
            }
            
            return packages;
        }

        protected override int Add(SqlConnection conn, Package entity)
        {
            var sql = $"INSERT INTO {TableName} VALUES ('{entity.Name}','{entity.StartDate}','{entity.EndDate}','{entity.Description}',{entity.BasePrice},{entity.AgencyCommission})";
            var rowsAffected = new SqlCommand(sql, conn).ExecuteNonQuery();

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (rowsAffected < 1) return int.MinValue; // return negative if the command failed
            return Database.GetLastAssignedId(conn, TableName); // return the id of the item just added
        }

        protected override bool Delete(SqlConnection conn, Package entity)
        {
            new SqlCommand($"DELETE FROM Packages_Products_Suppliers WHERE PackageId={entity.PackageId}", conn).ExecuteNonQuery();
            return DeleteById(entity.PackageId, "PackageId", conn);
        }


        protected override bool Update(SqlConnection conn, Package entity)
        {
            return new SqlCommand(
                $"UPDATE {TableName} SET PkgName='{entity.Name}',PkgStartDate='{entity.StartDate}',PkgEndDate='{entity.EndDate}',PkgDesc='{entity.Description}',PkgBasePrice={entity.BasePrice},PkgAgencyCommission={entity.AgencyCommission} WHERE PackageId={entity.PackageId}",
                conn).ExecuteNonQuery() > 0;
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
                    result.Add(ProductSupplierEntityProvider.ParseProductSupplier(reader));
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

        #endregion

    }
}