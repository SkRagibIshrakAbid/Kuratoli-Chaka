using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repo
{
    public class AdminBusRouteRepo : IRepositoryAdmin<BusRoute, int>
    {
        CircularBusEntities db;
        public AdminBusRouteRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public void Add(BusRoute e)
        {
            db.BusRoutes.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = db.BusRoutes.FirstOrDefault(e => e.BR_Id == id);
            db.BusRoutes.Remove(u);
            db.SaveChanges();
        }

        public void Edit(BusRoute e)
        {
            var u = db.BusRoutes.FirstOrDefault(en => en.BR_Id == e.BR_Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public BusRoute Get(int id)
        {
            return db.BusRoutes.FirstOrDefault(e => e.BR_Id == id);
        }

        public List<BusRoute> Get()
        {
            return db.BusRoutes.ToList();
        }
    }
}
