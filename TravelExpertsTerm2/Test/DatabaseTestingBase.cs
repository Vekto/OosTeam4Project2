using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using TravelDatabase;

namespace Test
{
    public abstract class DatabaseTestingBase
    {
        private const string ConnectionStringFilePath = @"TestDatabaseConnectionString.txt";

        /// <summary>
        ///     Connection string used by all the database functions. Defaults to the first line
        ///     in the file <see cref="ConnectionStringFilePath" />, or null if the file doesn't exist.
        /// </summary>
        [CanBeNull]
        private static string ConnectionString { get; set; } =
            File.Exists(ConnectionStringFilePath)
                ? File.ReadLines(ConnectionStringFilePath).FirstOrDefault()
                : null;

        protected DatabaseTestingBase()
        {
            if (ConnectionString == null) throw new InvalidOperationException(
                $"No connection string for test database. Please create {ConnectionStringFilePath} in execution directory.");
            Database.ConnectionString = ConnectionString;
        }
    }
}
