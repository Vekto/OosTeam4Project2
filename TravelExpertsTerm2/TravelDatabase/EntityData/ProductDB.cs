// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDatabase.EntityProviders;

namespace TravelDatabase.EntityData
{
    public class ProductDB : IDataOperations<Product>
    {
        public bool AddEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Product GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        int IDataOperations<Product>.AddEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IDataOperations<Product>.GetEntities()
        {
            throw new NotImplementedException();
        }

        public static Product GetProductByID(int ProductID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT ProductId, ProdName " +
                "FROM Products " +
                "WHERE ProductId = @ProductId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", ProductID);
            try
            {
                connection.Open();
                SqlDataReader Reader = selectCommand.ExecuteReader
                    (CommandBehavior.SingleRow); // selecting by PK value
                if (Reader.Read())
                {
                    // we have  a customer
                    Product product = new Product();
                    product.ProductId = (int) Reader["ProductId"];
                    product.Name = (string)Reader["ProdName"];
                    return product;
                }
                else // no customer
                {
                    return null;
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
    }
}
