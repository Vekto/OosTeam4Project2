using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.EntityData
{
    public class PackageDB : IDataOperations<Package>
    {
        public bool AddEntity(Package entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Package entity)
        {
            throw new NotImplementedException();
        }

        public List<Package> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Package GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(Package entity)
        {
            throw new NotImplementedException();
        }

        //retrieves a single product from the DB
        public static Package GetPackage(int packageID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //builds our select string
            string selectStatement =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission  " +
                "FROM packages " +
                "WHERE PackageId = @PackageID";
            //makes a command
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("PackageId", packageID); //adds the one parameter
            try
            {
                connection.Open(); //opens our connection
                SqlDataReader packageReader = selectCommand.ExecuteReader
                    (CommandBehavior.SingleRow); //declares our reader and that we expect one record returned
                if (packageReader.Read())
                {
                    //we have a customer and populate it
                    Package package = new Package();
                    package.PackageId = (int) packageReader["PackageID"];
                    package.Name = packageReader["PkgName"].ToString();
                    package.StartDate = (DateTime) packageReader["pkgStartDate"];
                    package.EndDate = (DateTime) packageReader["pkgEndDate"];
                    package.Description = packageReader["pkgDesc"].ToString();
                    package.BasePrice = (decimal) packageReader["pkgBasePrice"];
                    package.Commission = (decimal) packageReader["pkgAgencyCommission"];

                    //return prod;//return our queried product

                    string prodSelectStatement = "Select ProductSupplierID, PS.ProductID, PS.SupplierID, P.ProductName, S.SupplierName " +
                                                 "From *Packages_Products_Suppliers as PS," +
                                                 "INNER JOIN Products as P, on PS.ProductID = P.ProductID " +
                                                 "INNER JOIN Suppliers as S on PS.SupplierID = S.SupplierID " +
                                                 "Where PackageID = @PackageID " +
                                                 "Group by PackageID";
                    packageReader.Close();
                    SqlCommand prodSelectCommand = new SqlCommand(prodSelectStatement, connection);
                    prodSelectCommand.Parameters.AddWithValue("PackageID", package.PackageId); //adds the one parameter
                    SqlDataReader productReader = prodSelectCommand.ExecuteReader();
                    while (productReader.Read())
                    {
                        ProductSupplier newProductSupplier = new ProductSupplier();
                        newProductSupplier.ProductSupplierID = (int)productReader["ProductSupplierID"];
                        newProductSupplier.ProductID = (int) productReader["PS.ProductID"];
                        newProductSupplier.ProductName = productReader["P.ProductName"].ToString();
                        newProductSupplier.SupplierID = (int) productReader["PS.SupplierID"];
                        newProductSupplier.SupplierName = productReader["S.SupplierName"].ToString();
                        package.products.Add(newProductSupplier);
                    }
                    return package;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        ////adds new customer record and returns the ProductCode
        //public static int AddPackage(Package newPackage)
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection(); //makes a connection
        //    string insertStatment =
        //        "INSERT INTO Packages " +
        //        "(PackageID, ProductName) " +
        //        "Values(@ProductID, @ProductName"; //builds out select statment
        //    SqlCommand insertCommand = new SqlCommand(insertStatment, connection); //makes our command
        //    insertCommand.Parameters.AddWithValue("@ProductID", newPackage.ProductID);
        //    insertCommand.Parameters.AddWithValue("@ProductName", newPackage.ProductName);
        //        //sets the parameters of our search
        //    try
        //    {
        //        connection.Open(); //opens the connection
        //        int nr = insertCommand.ExecuteNonQuery(); //runs our command
        //        if (nr > 0) //success
        //        {
        //            int ident 
        //            "SELECT IDENT_CURRENT('Packages')"
        //            return; //returns the product code
        //        }
        //        else //not added
        //        {
        //            return 0;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        ////UPDATE

        //public static bool UpdateProduct(Product oldProduct, Product newProduct)
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection(); //makes the connection
        //    string updateStatement = "UPDATE Products " +
        //                             "SET ProductID = @ProductID, " +
        //                             "NewProductName = @NewProductName, " +
        //                             "WHERE ProductID = @ProductID " +
        //                             "AND ProductName = @OldProductName ";
        //        //select statment that does the update if our original product still matchs the product in the database

        //    SqlCommand updateCommand = new SqlCommand(updateStatement, connection); //creates the command
        //    updateCommand.Parameters.AddWithValue("@NewName", newProduct.ProductName);
        //    updateCommand.Parameters.AddWithValue("@ProductID", oldProduct.ProductID);
        //    updateCommand.Parameters.AddWithValue("@OldProductName", oldProduct.ProductName);
        //        //sets the parameters of our update
        //    try
        //    {
        //        connection.Open(); //opens the connection
        //        int count = updateCommand.ExecuteNonQuery(); //runs our command
        //        if (count > 0)
        //        {
        //            return true; //if we get a result return our succcess
        //        }
        //        else
        //        {
        //            return false; //return our failure!
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close(); //close that connection!
        //    }
        //}

        ////DELETE
        //public static bool DeleteProduct(Product product) // I'm so tired
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection(); //you know this
        //    string deleteStatement =
        //        "DELETE FROM Products " +
        //        "WHERE ProductCode = @ProductID " +
        //        "AND Description = @ProductName "; //it's all the same


        //    SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection); //are you still reading this?
        //    deleteCommand.Parameters.AddWithValue("@ProductID", product.ProductID);
        //    deleteCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
        //    try
        //    {
        //        connection.Open(); //opens the connection
        //        int count = deleteCommand.ExecuteNonQuery(); //deletes the product!
        //        if (count > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        connection.Close(); //close that connection!
        //    }
        //}
    }
}
