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
        protected override string TableName => "Products";

        protected override string GetByIdSql(int id)
            => $"SELECT * FROM Products WHERE ProductId={id}";

        protected override Product ReadSingleEntity(SqlDataReader reader)
        {
            return new Product
            {
                ProductId = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
        }

        protected override string DeleteEntitySql(Product entity)
            => $"DELETE FROM Products WHERE ProductId={entity.ProductId}";

        protected override string AddEntitySql(Product entity)
            => $"INSERT INTO Products VALUES('{entity.Name}')";

        protected override string UpdateEntitySql(Product entity)
            => $"UPDATE Products SET ProdName='{entity.Name}' WHERE ProductId={entity.ProductId}";
    }
}