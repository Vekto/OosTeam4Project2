// Author: Team 4 (See Annotations)
// Project: TravelExpertsTerm2
// Date: 2016-01

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.EntityProviders
{
    public class ProductSupplierEntityProvider : EntityProviderBase<ProductSupplier>
    {
        protected override string TableName => "Products_Suppliers";

        protected override IEnumerable<ProductSupplier> GetAll(SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        protected override ProductSupplier Get(SqlConnection conn, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Delete(SqlConnection conn, ProductSupplier entity)
        {
            // remove from packageproductsupplier where key2=id
            throw new NotImplementedException();
        }

        protected override int Add(SqlConnection conn, ProductSupplier entity)
        {
            throw new NotImplementedException();
        }

        protected override bool Update(SqlConnection conn, ProductSupplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
