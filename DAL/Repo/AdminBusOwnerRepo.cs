using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminBusOwnerRepo : IRepositoryAdmin<BusOwner, int>
    {
        CircularBusEntities db;
        public AdminBusOwnerRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public void Add(BusOwner e)
        {
            db.BusOwners.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = db.BusOwners.FirstOrDefault(e => e.O_Id == id);
            db.BusOwners.Remove(u);
            db.SaveChanges();
        }

        public void Edit(BusOwner e)
        {
            var u = db.BusOwners.FirstOrDefault(en => en.O_Id == e.O_Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public BusOwner Get(int id)
        {
            return db.BusOwners.FirstOrDefault(e => e.O_Id == id);
        }

        public List<BusOwner> Get()
        {
            return db.BusOwners.ToList();
        }
    }
}
