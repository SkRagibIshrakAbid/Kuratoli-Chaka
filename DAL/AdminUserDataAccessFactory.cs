using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminUserDataAccessFactory
    {
        static CircularBusEntities db;
        static AdminUserDataAccessFactory()
        {
            db = new CircularBusEntities();
        }
        public static IRepositoryAdmin<User, int> AdminUserDataAccess()
        {
            return new AdminUserRepo(db);
        }
        public static IRepositoryAdmin<BusOwner, int> AdminBusOwnerDataAccess()
        {
            return new AdminBusOwnerRepo(db);
        }

        public static IRepositoryAdmin<BusInfo, int> AdminBusInfoDataAccess()
        {
            return new AdminBusInfoRepo(db);
        }
        public static IRepositoryAdmin<BusRoute, int> AdminBusRouteDataAccess()
        {
            return new AdminBusRouteRepo(db);
        }
    }
}
