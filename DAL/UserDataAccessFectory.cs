using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDataAccessFectory
    {
        static CircularBusEntities db = new CircularBusEntities();

        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }

        public static IRepository<Cart, int> CartDataAccess()
        {
            return new CartRepo(db);
        }

        public static IRepository<User, int> SuperDataAccess()
        {
            return new SupervisorRepo(db);
        }

        public static IAuth<Token> AuthDataAccess()
        {
            return new AuthRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new AuthRepo(db);
        }

        /*public static IRepository<BusRoute, int> BusRouteDataAccess()
        {
            return new BusRouteRepo(db);
        }*/
    }
}
