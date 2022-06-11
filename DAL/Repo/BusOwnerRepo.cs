using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class BusOwnerRepo : IRepositoryBusOwner<User, int>, IAuthBusOwner, IRepositoryBus<BusInfo, int>
    {
        private CircularBusEntities db;

        public BusOwnerRepo(CircularBusEntities db)
        {
            this.db = db;
        }


        public User Add(User obj)
        {
            db.Users.Add(obj);
            db.SaveChanges();
            return db.Users.FirstOrDefault();
        }

        public List<BusInfo> Buslist(int id)
        {
            return db.BusInfoes.Where(dn => dn.B_OwnedBy == id).ToList();
        }

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
            return db.Users.FirstOrDefault(x => x.U_Id == id);
        }

        public List<User> Get()
        {
            return db.Users.Where(dn => dn.U_Role == "BusOwner  ").ToList();
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken.Equals(token) && e.ExpiredAt == null && e.User.U_Role == "BusOwner  ");
            return rs;
        }

        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
            if (t != null)
            {
                t.ExpiredAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Token Authenticate(User user)
        {
            var u = db.Users.FirstOrDefault(en => en.U_UserName.Equals(user.U_UserName) && en.U_Password.Equals(user.U_Password) && en.U_Role == "BusOwner  ");
            Token t = null;
            if (u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserId = u.U_Id;
                t.AccessToken = token;
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }

    }
}
