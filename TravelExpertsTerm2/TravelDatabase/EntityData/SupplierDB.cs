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
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliersList = new List<Supplier>(); //create emtpy list
            string connectionString = "Data Source=localhost\\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string selectStatement = "SELECT * FROM Suppliers ORDER BY SupplierID";
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
        }

        public static bool CheckDependency(int supplierID)
        {
            string connectionString = "Data Source=ELF5OOSD212989\\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string selectStatement = "SELECT SupplierID FROM Products_Suppliers as p WHERE p.SupplierID = @SupplierID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SupplierID", supplierID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //while there is data
                {
                    return true;
                }
                else
                {
                    return false;
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
        }

        public static bool DeleteSupplier(int supplierID)
        {
            string connectionString = "Data Source=ELF5OOSD212989\\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string deleteStatement =
                "DELETE FROM Suppliers " +
                "WHERE SupplierID = @SupplierID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@SupplierID", supplierID);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    //form1.updateListView(getSuppliers());
                    return true;
                }
                else
                {
                    return false;
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
        }

        public static bool AddSupplier(Supplier supplier)
        {
            //in form, validate before doing this
            //Supplier supplier = new Supplier(); -->do on form --> passing the text objects       
            string connectionString = "Data Source=ELF5OOSD212989\\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                //create insert statement and parameters
                string insertStatement =
                    "INSERT INTO Suppliers " +
                    "(SupplierID, SupName) " +
                    "Values(@SupplierID, @SupName)";
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                insertCommand.Parameters.AddWithValue("@SupName", supplier.SupName);
                connection.Open();

                int nr = insertCommand.ExecuteNonQuery(); //counts how many new rows were inserted
                if (nr > 0) //if insert was successful
                {
                    return true;
                }
                else // insert was not successful
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }//END OF ADD METHOD
        
        #endregion

       

    } //END OF SUPPLIER DB
}//END OF NAMESPACE