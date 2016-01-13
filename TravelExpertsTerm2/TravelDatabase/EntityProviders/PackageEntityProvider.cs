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
        protected override string TableName { get; }

        protected override string GetAllSql()
        {
            throw new NotImplementedException();
        }

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