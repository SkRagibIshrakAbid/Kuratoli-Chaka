using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BusOwnerAuthService
    {
        

        public static TokenModel Authenticate(BusOwnerModel user)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<User, BusOwnerModel>();
                c.CreateMap<BusOwnerModel, User>();
                c.CreateMap<Token, TokenModel>();
                c.CreateMap<TokenModel, Token>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(user);
            var result = BusOwnerDataAccessFactory.BusAuthDataAccess().Authenticate(data);
            var token = mapper.Map<TokenModel>(result);
            return token;
        }
        public static bool IsAuthenticated(string token)
        {
            var rs = BusOwnerDataAccessFactory.BusAuthDataAccess().IsAuthenticated(token);
            return rs;

        }
        public static bool Logout(string token)
        {
            return BusOwnerDataAccessFactory.BusAuthDataAccess().Logout(token);
        }

    }
}
