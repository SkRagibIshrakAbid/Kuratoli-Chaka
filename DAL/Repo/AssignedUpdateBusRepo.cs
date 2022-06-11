using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;

namespace DAL.Repo
{
   public class AssignedUpdateBusRepo : IRepoSuper<BusInfo, int>
    {
        private CircularBusEntities db;

        public AssignedUpdateBusRepo(CircularBusEntities db)
        {
            this.db = db;
        }

        public BusInfo AssignedBus(int id)
        {
            return db.BusInfoes.FirstOrDefault(x => x.B_SId == id);
        }

        public BusInfo UpdateSeat(int id, int s)
        {
            var data = db.BusInfoes.FirstOrDefault(x => x.B_Id == id);

            db.Entry(data).CurrentValues.SetValues(data.B_AvailableSeat = s);
            db.SaveChanges();
            return db.BusInfoes.FirstOrDefault();
        }
    }
}
