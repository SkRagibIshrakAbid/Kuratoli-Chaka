using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BusOwnerDataAccessFactory
    {
        static CircularBusEntities db = new CircularBusEntities();
        public static IRepositoryBusOwner<User, int> BusOwnerFirstDataAccess()
        {
            return new BusOwnerRepo(db);
        }
        public static IRepositoryBus<BusInfo, int> BusOwnerSecondDataAccess()
        {
            return new BusOwnerRepo(db);
        }

        public static IRepositoryBusOwner<BusInfo, int> BusFirstDataAccess()
        {
            return new BusRepo(db);
        }
        public static IRepositoryBusOwner<BusRoute, int> BusRouteFirstDataAccess()
        {
            return new BusRouteRepo(db);
        }
        public static IRepositoryBus<BusRoute, int> BusRouteSecondDataAccess()
        {
            return new BusRouteRepo(db);
        }
        public static IRepositoryBus<Cart, int> BusOwnerCartDataAccess()
        {
            return new BusOwnerCartRepo(db);
        }
        public static IAuthBusOwner BusAuthDataAccess()
        {
            return new BusOwnerRepo(db);
        }
        public static IRepositoryBusSearch<BusInfo, string> BusSearchDataAccess()
        {
            return new BusOwnerBusSearchRepo(db);
        }

    }
}
