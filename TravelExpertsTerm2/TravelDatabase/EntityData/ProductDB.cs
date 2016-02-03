// ReSharper disable All
using System;
using System.Collections.Generic;
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
    }
}
