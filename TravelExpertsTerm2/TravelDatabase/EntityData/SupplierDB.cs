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

        #region Methods
        //GetSuppliers()
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliersList = new List<Supplier>; //create emtpy list
            SqlConnection connection = TravelExpertsDB.GetConnection(); //create database connection

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())  //while there is data
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierID = (int)reader["SupplierID"];
                    supplier.SupName = (string)reader["SupName"];
                    suppliersList.Add(supplier); //add supplier object to list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return suppliersList;
        } //END OF GetSuppliers()



        static string selectStatement = "SELECT * FROM Suppliers";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

        try{


        
            }
    }//END OF SUPPLIER DB
}//END OF NAMESPACE

