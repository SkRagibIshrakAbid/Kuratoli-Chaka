using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IRepository<User, int>
    {
        private CircularBusEntities db;

        public UserRepo(CircularBusEntities db)
        {
            this.db = db;
        }

         
         public User Add(User obj)
         {
             db.Users.Add(obj);
             db.SaveChanges();
             return db.Users.FirstOrDefault();
         }

        public User AddtoCart(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> Buslist(int id)
        {
            throw new NotImplementedException();
        }



        /*
        public bool Add(User obj)
         {
             db.Users.Add(obj);
             if (db.SaveChanges() != 0)  return true;

             return false;
        }
        */
        public User Delete(int id)
        {
            var e = db.Users.FirstOrDefault(dn => dn.U_Id == id);
            db.Users.Remove(e);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public User Edit(User u)
        {
            var p = db.Users.FirstOrDefault(dn => dn.U_Id == u.U_Id);
            db.Entry(p).CurrentValues.SetValues(u);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(x =>x.U_Id == id);
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public List<User> Purchase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
