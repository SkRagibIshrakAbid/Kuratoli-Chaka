using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using DAL;

namespace BLL.Services
{
    public class SuperAuthService
    {
        public static TokenModel Authenticate(string uname, string pass)
        {
            var token = SuperDataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
                
            if (token != null)
            {

                return new TokenModel() { AccessToken = token.AccessToken, CreatedAt = token.CreatedAt, ExpiredAt = token.ExpiredAt };
            }
            return null;
        }
        public static bool ValidateToken(string key)
        {
            var token = SuperDataAccessFactory.TokenDataAccess().Get(key);
             
            if (token != null && token.ExpiredAt == null)
            {
                return true;
            }
            return false;
        }
    }
}
