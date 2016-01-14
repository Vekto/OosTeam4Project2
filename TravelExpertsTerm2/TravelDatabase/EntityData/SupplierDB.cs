using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.EntityData
{
    public class SupplierDB
    {
        #region Interface Methods
        public bool AddEntity(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Supplier GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(Supplier entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);  //calls the connection
            return connection;
        }

        static SqlConnection connection = GetConnection();

        static string selectStatement = "SELECT * FROM Suppliers";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

        try{


        
            }
    }//END OF SUPPLIER DB
}//END OF NAMESPACE

