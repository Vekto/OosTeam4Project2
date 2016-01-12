// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    [PublicAPI]
    public sealed class SupplierEntityProvider : EntityProviderBase<Supplier>
    {
        protected override string GetAllSql()
        {
            throw new NotImplementedException();
        }

        protected override string GetByIdSql(int id)
        {
            throw new NotImplementedException();
        }

        protected override Supplier ReadSingleEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override string DeleteEntitySql(Supplier entity)
        {
            throw new NotImplementedException();
        }

        protected override string AddEntitySql(Supplier entity)
        {
            throw new NotImplementedException();
        }

        protected override string UpdateEntitySql(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}