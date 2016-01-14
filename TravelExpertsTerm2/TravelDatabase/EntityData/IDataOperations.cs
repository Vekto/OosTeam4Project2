using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.EntityData
{
    // This is an interface, https://msdn.microsoft.com/en-us/library/ms173156.aspx
    // Two important ones you'll see are IEnumerable<T> & INotifyPropertyChanged.
    public interface IDataOperations<TEntity>

        // constraint (where clause) makes it so that the type that TEntity is a class with a default constructor
        // https://msdn.microsoft.com/en-us/library/d5x73970.aspx
        where TEntity : class, new() 
    {
        //defines signatures that the DB classes must implement
        List<TEntity> GetEntities();
        TEntity GetEntityById(int id);
        bool DeleteEntity(TEntity entity);
        bool AddEntity(TEntity entity);
        bool UpdateEntity(TEntity entity);
    }
}
