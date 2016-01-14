using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.EntityData
{
    [Heidi]
    interface IDataOperations<TEntity> where TEntity : class, new() //constraint makes it so that the type that TEntity is a class with a default constructor
    {
        //defines signatures that the DB classes must implement
        List<TEntity> GetEntities();
        TEntity GetEntityByID(int id);
        bool DeleteEntity(TEntity entity);
        bool AddEntity(TEntity entity);
        bool UpdateEntity(TEntity entity);
    }
}
