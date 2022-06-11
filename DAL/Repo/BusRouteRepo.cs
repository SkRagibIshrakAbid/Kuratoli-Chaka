using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class BusRouteRepo : IRepositoryBusOwner<BusRoute, int>, IRepositoryBus<BusRoute, int>
    {
        private CircularBusEntities db;

        public BusRouteRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public BusRoute Add(BusRoute obj)
        {
            db.BusRoutes.Add(obj);
            db.SaveChanges();
            return db.BusRoutes.FirstOrDefault();
        }

        public List<BusRoute> Buslist(int id)
        {
            return db.BusRoutes.Where(dn => dn.BR_BId == id).ToList();
        }

        public BusRoute Delete(int id)
        {
            var bus = db.BusRoutes.FirstOrDefault(dn => dn.BR_Id == id);
            db.BusRoutes.Remove(bus);
            db.SaveChanges();
            return db.BusRoutes.FirstOrDefault();
        }

        public BusRoute Edit(BusRoute obj)
        {
            var p = db.BusRoutes.FirstOrDefault(dn => dn.BR_Id == obj.BR_Id);
            db.Entry(p).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return db.BusRoutes.FirstOrDefault();
        }

        public BusRoute Get(int id)
        {
            return db.BusRoutes.FirstOrDefault(dn => dn.BR_BId == id);
        }

        public List<BusRoute> Get()
        {
            return db.BusRoutes.ToList();
        }
    }
}
