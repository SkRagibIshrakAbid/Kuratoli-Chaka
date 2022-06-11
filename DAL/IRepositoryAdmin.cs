using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositoryAdmin<T, ID>
    {
        void Add(T obj);
        T Get(ID id);
        List<T> Get();
        void Edit(T obj);
        void Delete(ID id);
    }
}
