using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BusOwnerBusSearchRepo : IRepositoryBusSearch<BusInfo, string>
    {
        private CircularBusEntities db;

        public BusOwnerBusSearchRepo(CircularBusEntities db)
        {
            this.db = db;
        }

        public List<BusInfo> Buslist(string id)
        {
            return db.BusInfoes.Where(dn => dn.B_Name == id).ToList();

        }
    }
}
