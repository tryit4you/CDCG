using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDCG.API.Data.Interfaces
{
    public interface IBaseRepository<T> where  T :class
    {
        T GetById(string id);
        bool Post(T obj);
        bool Put(T obj);
        bool Delete(string id);
        IEnumerable<T> GetAll();
        void SaveChange();
    }
}
