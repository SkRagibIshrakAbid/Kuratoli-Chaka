using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BusRepo : IRepositoryBusOwner<BusInfo, int>
    {
        private CircularBusEntities db;

        public BusRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public BusInfo Add(BusInfo obj)
        {
            db.BusInfoes.Add(obj);
            db.SaveChanges();
            return db.BusInfoes.FirstOrDefault();
        }

        public BusInfo Delete(int id)
        {
            var bus = db.BusInfoes.FirstOrDefault(dn => dn.B_Id == id);
            db.BusInfoes.Remove(bus);
            db.SaveChanges();
            return db.BusInfoes.FirstOrDefault();
        }

        public BusInfo Edit(BusInfo obj)
        {
            var p = db.BusInfoes.FirstOrDefault(dn => dn.B_Id == obj.B_Id);
            db.Entry(p).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return db.BusInfoes.FirstOrDefault();
        }

        public BusInfo Get(int id)
        {
            return db.BusInfoes.FirstOrDefault(dn => dn.B_Id == id);
        }

        public List<BusInfo> Get()
        {
            return db.BusInfoes.Where(dn => dn.B_Status == "Active").ToList();
        }
    }
}
