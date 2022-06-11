using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T, ID>
    {
        T Add(T obj);
        T Get(ID id);
        List<T> Get();
        T Edit(T obj);
        T Delete(ID id);
        List<T> Buslist(ID id);
        T AddtoCart(T obj);
        List<T> Purchase(int id);
    }
}
