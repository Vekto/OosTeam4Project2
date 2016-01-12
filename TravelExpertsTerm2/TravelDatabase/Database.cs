// Author: Team 5 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System.IO;
using System.Linq;
using JetBrains.Annotations;
using TravelDatabase.EntityProviders;

namespace TravelDatabase
{
    /// <summary>
    ///     Global database functions like creating connections.
    /// </summary>
    [Chad]
    [PublicAPI]
    public static class Database
    {
        [Devin] public const string ConnectionStringFilePath = @"ConnectionString.txt";

        /// <summary>
        ///     Connection string used by all the database functions. Defaults to the first line
        ///     in the file <see cref="ConnectionStringFilePath" />, or null if the file doesn't exist.
        /// </summary>
        [Devin]
        [CanBeNull]
        public static string ConnectionString { get; set; } =
            File.Exists(ConnectionStringFilePath)
                ? File.ReadLines(ConnectionStringFilePath).FirstOrDefault()
                : null;

        /// <summary>
        /// Provides database operations for <see cref="Package"/> entities
        /// </summary>
        [ProvidesContext]
        public static PackageEntityProvider PackageProvider { get; } 
            = new PackageEntityProvider();

        /// <summary>
        /// Provides database operations for <see cref="Product"/> entities
        /// </summary>
        [ProvidesContext]
        public static ProductEntityProvider ProductProvider { get; }
            = new ProductEntityProvider();

        /// <summary>
        /// Provides database operations for <see cref="ProductSupplier"/> entities
        /// </summary>
        [ProvidesContext]
        public static ProductSupplierEntityProvider ProductSupplierProvider { get; }
            = new ProductSupplierEntityProvider();

        /// <summary>
        /// Provides database operations for <see cref="Supplier"/> entities
        /// </summary>
        [ProvidesContext]
        public static SupplierEntityProvider SupplierProvider { get; }
            = new SupplierEntityProvider();
    }
}