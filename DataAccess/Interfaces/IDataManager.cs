
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IDataManager<T>
    {
        List<T> GetAll();
        T GetOne(int id);
        T Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
