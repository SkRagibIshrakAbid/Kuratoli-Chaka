using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminUserRepo : IRepositoryAdmin<User, int>
    {
        CircularBusEntities db;
        public AdminUserRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public void Add(User e)
        {
            db.Users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = db.Users.FirstOrDefault(e => e.U_Id == id);
            db.Users.Remove(u);
            db.SaveChanges();
        }

        public void Edit(User e)
        {
            var u = db.Users.FirstOrDefault(en => en.U_Id == e.U_Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.U_Id == id);
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }
    }
}
