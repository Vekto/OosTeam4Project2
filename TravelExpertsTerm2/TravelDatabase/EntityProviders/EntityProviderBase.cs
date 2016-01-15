// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.CodeDom;
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
        private static string NullConnectionStringExceptionMessage
            => $"Connection string is null. Check {Database.ConnectionStringFilePath}";

        [NotNull]
        [ItemNotNull]
        protected abstract IEnumerable<TEntity> GetAll([NotNull]SqlConnection conn);

        [CanBeNull]
        protected abstract TEntity Get([NotNull]SqlConnection conn, int id);

        protected abstract bool Delete([NotNull]SqlConnection conn, [NotNull]TEntity entity);
        protected abstract int Add([NotNull]SqlConnection conn, [NotNull]TEntity entity);
        protected abstract bool Update([NotNull]SqlConnection conn, [NotNull]TEntity entity);

        [NotNull]
        protected abstract string TableName { get; }



        // Internal ctor to block inheretence outside of this assembly
        internal EntityProviderBase()
        {
        }

        #region Protected Helpers

        [ContractAnnotation("idColumnName:null=>halt; conn:null=>halt")]
        protected bool DeleteById(int id, [NotNull]string idColumnName, [NotNull]SqlConnection conn)
        {
            if (idColumnName == null) throw new ArgumentNullException(nameof(idColumnName));
            var sql = $"DELETE FROM {TableName} WHERE {idColumnName}={id}";
            return new SqlCommand(sql, conn).ExecuteNonQuery() > 0; // success means 1 row was affected
        }

        #endregion

        #region DatabaseOperation

        [ContractAnnotation("func:null=>halt")]
        private TReturn DatabaseOperation<TReturn>(Func<SqlConnection, TReturn> func)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                return func(conn);
            }
        }

        [ContractAnnotation("func:null=>halt")]
        private TReturn DatabaseOperation<TReturn, TParam>(
            [NotNull] Func<SqlConnection, TParam, TReturn> func,
            TParam param)
        {
            if (Database.ConnectionString == null)
                throw new InvalidOperationException(NullConnectionStringExceptionMessage);
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var conn = new SqlConnection(Database.ConnectionString))
            {
                conn.Open();
                return func(conn, param);
            }
        }

        #endregion

        #region IDataOperations<TEntity>

        [Pure]
        [NotNull]
        [ItemNotNull]
        public IEnumerable<TEntity> GetEntities() => DatabaseOperation(GetAll);
        //{
        //    if (Database.ConnectionString == null)
        //        throw new InvalidOperationException(NullConnectionStringExceptionMessage);

        //    using (var conn = new SqlConnection(Database.ConnectionString))
        //    {
        //        conn.Open();
        //        return GetAll(conn);
        //    }
        //}

        [Pure]
        [CanBeNull]
        public TEntity GetEntityById(int id) => DatabaseOperation(Get, id);
        //{
        //    if (Database.ConnectionString == null)
        //        throw new InvalidOperationException(NullConnectionStringExceptionMessage);

        //    using (var conn = new SqlConnection(Database.ConnectionString))
        //    {
        //        conn.Open();
        //        return GetEntity(conn, id);
        //    }
        //}

        [ContractAnnotation("entity:null=>halt")]
        public bool DeleteEntity([NotNull] TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return DatabaseOperation(Delete, entity);
        }
        //{
        //    if (Database.ConnectionString == null)
        //        throw new InvalidOperationException(NullConnectionStringExceptionMessage);

        //    using (var conn = new SqlConnection(Database.ConnectionString))
        //    {
        //        conn.Open();
        //        return Delete(conn, entity);
        //    }
        //}

        [ContractAnnotation("entity:null=>halt")]
        public int AddEntity([NotNull] TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return DatabaseOperation(Add, entity);
        }
        //{
        //    if (Database.ConnectionString == null)
        //        throw new InvalidOperationException(NullConnectionStringExceptionMessage);

        //    using (var conn = new SqlConnection(Database.ConnectionString))
        //    {
        //        conn.Open();
        //        return Add(conn, entity);
        //    }
        //}

        [ContractAnnotation("entity:null=>halt")]
        public bool UpdateEntity([NotNull] TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return DatabaseOperation(Update, entity);
        }
        //{
        //    if (Database.ConnectionString == null)
        //        throw new InvalidOperationException(NullConnectionStringExceptionMessage);

        //    using (var conn = new SqlConnection(Database.ConnectionString))
        //    {
        //        conn.Open();
        //        return Update(conn, entity);
        //    }
        //}

        #endregion

    }
}