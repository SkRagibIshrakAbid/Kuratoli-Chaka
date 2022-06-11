using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;

namespace DAL.Repo
{
    public class SupervisorRepo : IRepository<User, int>
    {
        private CircularBusEntities db;

        public SupervisorRepo(CircularBusEntities db)
        {
            this.db = db;
        }

        public User Add(User obj)
        {
            obj.U_Status = "pending";
            db.Users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public User AddtoCart(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> Buslist(int id)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Edit(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            var data = (from s in db.Users
                        where s.U_Id == id &&
                        s.U_Role == "Supervisor"
                        select s).FirstOrDefault();
            return data;
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public List<User> Purchase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
