﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDatabase.EntityProviders;

namespace TravelDatabase.EntityData
{
    public class ProductSupplierDB : IDataOperations<ProductSupplier>
    {
        public List<ProductSupplier> GetEntities()
        {
            throw new NotImplementedException();
        }
        public bool DeleteEntity(ProductSupplier productSupplier)
        {
            throw new NotImplementedException();
        }
        public bool AddEntity(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }
        public bool UpdateEntity(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }
        public ProductSupplier GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProductSupplier> IDataOperations<ProductSupplier>.GetEntities()
        {
            throw new NotImplementedException();
        }

        int IDataOperations<ProductSupplier>.AddEntity(ProductSupplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
