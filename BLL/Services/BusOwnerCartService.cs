using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;

namespace BLL.Services
{
    public class BusOwnerCartService
    {
        public static List<CartModel> GetBusList(int id) //has issues with irepo //solved
        {
            var config = new MapperConfiguration(c => c.CreateMap<Cart, CartModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CartModel>>(BusOwnerDataAccessFactory.BusOwnerCartDataAccess().Buslist(id));
            return data;
        }
    }
}
