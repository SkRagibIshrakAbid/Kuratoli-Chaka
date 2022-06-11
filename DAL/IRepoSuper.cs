using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepoSuper<T, ID>
    {
        T AssignedBus(int id);

        T UpdateSeat(int id, int s);
    }
}
