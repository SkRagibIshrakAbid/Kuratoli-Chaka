using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositoryBusOwner<T, ID>
    {
        T Add(T obj);
        T Get(ID id);
        List<T> Get();
        T Edit(T obj);
        T Delete(ID id);
    }
}
