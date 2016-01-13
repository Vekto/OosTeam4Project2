// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using JetBrains.Annotations;

namespace TravelDatabase.EntityProviders
{
    /// <summary>
    /// Standard, boilerplate code for performing data operations. Creates and disposes of 
    /// connection and data-reader objects automatically, provides an API through inheritence 
    /// for implementing entity data operations with the fewest lines of code.
    /// </summary>
    /// <typeparam name="TEntity">Entity Class</typeparam>
    [Devin]
    [NoReorder]
    public abstract class EntityProviderBase<TEntity> : IDataOperations<TEntity>
        where TEntity : class, new()
    {
        protected abstract string TableName { get; }
        protected virtual string GetAllSql() => $"SELECT * FROM {TableName}";
        protected abstract string GetByIdSql(int id);
        protected abstract TEntity ReadSingleEntity(SqlDataReader reader);
        protected abstract string DeleteEntitySql(TEntity entity);
        protected abstract string AddEntitySql(TEntity entity);
        protected abstract string UpdateEntitySql(TEntity entity);

        private static string NullConnectionStringExceptionMessage
            => $"Connection string is null. Check {Database.ConnectionStringFilePath}";

        // Internal ctor to block inheretence outside of this assembly
        internal EntityProviderBase()
        {
        }

        public IEnumerable<TEntity> GetEntities()
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                using (var reader = new SqlCommand(GetAllSql(), conn).ExecuteReader())
                {
                    while (reader.Read()) yield return ReadSingleEntity(reader);
                }
            }
        }

        [CanBeNull]
        public TEntity GetEntityById(int id)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                using (var reader = new SqlCommand(GetByIdSql(id), conn).ExecuteReader())
                {
                    return reader.Read() ? ReadSingleEntity(reader) : null;
                }
            }
        }

        public bool DeleteEntity(TEntity entity)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                // On success, one row is affected. Therefore, we return 'rowsAffected == 1'
                return new SqlCommand(DeleteEntitySql(entity), conn).ExecuteNonQuery() == 1;
            }
        }

        public int AddEntity(TEntity entity)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                // On success, one row is affected. Therefore, we return 'rowsAffected == 1'
                if (new SqlCommand(AddEntitySql(entity), conn).ExecuteNonQuery() != 1) return -1;
                return Convert.ToInt32(new SqlCommand($"SELECT IDENT_CURRENT('{TableName}')", conn).ExecuteScalar());
            }
        }

        public bool UpdateEntity(TEntity entity)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                // On success, one row is affected. Therefore, we return 'rowsAffected == 1'
                return new SqlCommand(UpdateEntitySql(entity), conn).ExecuteNonQuery() == 1;
            }
        }
    }
}