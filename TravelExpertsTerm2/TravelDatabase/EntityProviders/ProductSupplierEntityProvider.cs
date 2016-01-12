// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [PublicAPI]
    public sealed class ProductSupplierEntityProvider : EntityProviderBase<ProductSupplier>
    {
        protected override string GetAllSql()
        {
            throw new NotImplementedException();
        }

        protected override string GetByIdSql(int id)
        {
            throw new NotImplementedException();
        }

        protected override ProductSupplier ReadSingleEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override string DeleteEntitySql(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }

        protected override string AddEntitySql(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }

        protected override string UpdateEntitySql(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }
    }
}