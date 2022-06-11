using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminBusInfoRepo : IRepositoryAdmin<BusInfo, int>
    {
        CircularBusEntities db;
        public AdminBusInfoRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public void Add(BusInfo e)
        {
            db.BusInfoes.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = db.BusInfoes.FirstOrDefault(e => e.B_Id == id);
            db.BusInfoes.Remove(u);
            db.SaveChanges();
        }

        public void Edit(BusInfo e)
        {
            var u = db.BusInfoes.FirstOrDefault(en => en.B_Id == e.B_Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public BusInfo Get(int id)
        {
            return db.BusInfoes.FirstOrDefault(e => e.B_Id == id);
        }

        public List<BusInfo> Get()
        {
            return db.BusInfoes.ToList();
        }
    }
}
