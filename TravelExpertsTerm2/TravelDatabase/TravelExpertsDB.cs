using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace TravelDatabase
{
    /// <summary>
    ///     Global database functions like creating connections.
    /// </summary>
    [Chad]
    public static class TravelExpertsDb
    {
        [Devin]
        private const string ConnectionStringFilePath = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;Integrated Security=True";

        /// <summary>
        ///     Connection string used by all the database functions. Defaults to the first line 
        ///     in the file <see cref="ConnectionStringFilePath"/>, or null if the file doesn't exist.
        /// </summary>
        [Devin]
        [CanBeNull]
        public static string ConnectionString { get; set; } =
            File.Exists(ConnectionStringFilePath)
            ? File.ReadLines(ConnectionStringFilePath).FirstOrDefault()
            : null;
    }
}
