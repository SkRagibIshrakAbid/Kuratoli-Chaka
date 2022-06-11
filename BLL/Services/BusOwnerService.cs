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
    public class BusOwnerService
    {
        public static List<BusOwnerModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<User, BusOwnerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusOwnerModel>>(BusOwnerDataAccessFactory.BusOwnerFirstDataAccess().Get());
            return data;
        }
        public static BusOwnerModel Get(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<User, BusOwnerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusOwnerModel>(BusOwnerDataAccessFactory.BusOwnerFirstDataAccess().Get(id));
            return data;
        }
        public static List<BusModel> GetBusList(int id) //has issues with irepo //solved
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusInfo, BusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusModel>>(BusOwnerDataAccessFactory.BusOwnerSecondDataAccess().Buslist(id));
            return data;
        }
        public static void Add(BusOwnerModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusOwnerModel, User>());
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(obj);
            BusOwnerDataAccessFactory.BusOwnerFirstDataAccess().Add(data);
        }
        public static void Edit(BusOwnerModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusOwnerModel, User>());
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(obj);
            BusOwnerDataAccessFactory.BusOwnerFirstDataAccess().Edit(data);
        }
        public static void Delete(int i)
        {

            BusOwnerDataAccessFactory.BusOwnerFirstDataAccess().Delete(i);
        }
    }
}
