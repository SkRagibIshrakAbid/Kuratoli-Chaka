using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;
using DAL.Repo;

namespace DAL
{
    public class SuperDataAccessFactory
    {
        static CircularBusEntities db = new CircularBusEntities();

        public static IRepoSuper<BusInfo, int> BusDataAccess()
        {
            return new AssignedUpdateBusRepo(db);
        }

        public static IAuth<Token> AuthDataAccess()
        {
            return new AuthRepo(db);
        }

        public static IRepository<Token, string> TokenDataAccess()
        {
            return new AuthRepo(db);
        }
    }
}
