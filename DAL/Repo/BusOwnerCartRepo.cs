using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class BusOwnerCartRepo : IRepositoryBus<Cart, int>
    {
        private CircularBusEntities db;

        public BusOwnerCartRepo(CircularBusEntities db)
        {
            this.db = db;
        }

        public List<Cart> Buslist(int id)
        {
            return db.Carts.Where(dn => dn.BusInfo.B_OwnedBy == id).ToList();
        }
    }
}
