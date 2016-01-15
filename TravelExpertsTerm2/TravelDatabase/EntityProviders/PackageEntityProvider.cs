// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [PublicAPI]
    public sealed class PackageEntityProvider : EntityProviderBase<Package>
    {
        protected override string TableName => "Packages";

        protected override string GetAllSql() =>
            "SELECT pack.PackageId,pack.PkgName,pack.PkgDesc,pack.PkgStartDate,pack.PkgEndDate,pack.PkgBasePrice,pack.PkgAgencyCommission,p.ProductId,p.ProdName,s.SupplierId,s.SupName FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Packages pack, Products p, Suppliers s WHERE pps.PackageId=pack.PackageId AND pps.ProductSupplierId=ps.ProductSupplierId AND ps.ProductId=p.ProductId AND ps.SupplierId=s.SupplierId ORDER BY pack.PackageId";

        protected override string GetByIdSql(int id)
        {
            throw new NotImplementedException();
        }

        protected override Package ReadSingleEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override string DeleteEntitySql(Package entity)
        {
            throw new NotImplementedException();
        }

        protected override string AddEntitySql(Package entity)
        {
            throw new NotImplementedException();
        }

        protected override string UpdateEntitySql(Package entity)
        {
            throw new NotImplementedException();
        }
    }
}