// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [PublicAPI]
    public sealed class ProductEntityProvider : EntityProviderBase<Product>
    {
        protected override string GetAllSql()
        {
            throw new NotImplementedException();
        }

        protected override string GetByIdSql(int id)
        {
            throw new NotImplementedException();
        }

        protected override Product ReadSingleEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override string DeleteEntitySql(Product entity)
        {
            throw new NotImplementedException();
        }

        protected override string AddEntitySql(Product entity)
        {
            throw new NotImplementedException();
        }

        protected override string UpdateEntitySql(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}