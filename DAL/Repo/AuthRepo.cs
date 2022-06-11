using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        private CircularBusEntities db;

        public AuthRepo(CircularBusEntities db)
        {
            this.db = db;
        }
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return db.Tokens.FirstOrDefault();
        }

        public Token AddtoCart(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Authenticate(string uname, string pass)
        {
            var data = db.Users.FirstOrDefault(x => x.U_UserName.Equals(uname) && x.U_Password.Equals(pass));
            if (data != null)
            {
                var token = new Token();
                var r = new Random();
                var g = Guid.NewGuid();
                token.AccessToken = g.ToString();//random string
                token.CreatedAt = DateTime.Now;
                token.UserId = data.U_Id;
                token.ExpiredAt = null;

                db.Tokens.Add(token);
                db.SaveChanges();
                return token;

            }
            return null;
        }

        public List<Token> Buslist(string id)
        {
            throw new NotImplementedException();
        }

        public Token Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Token Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(id));
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public List<Token> Purchase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
