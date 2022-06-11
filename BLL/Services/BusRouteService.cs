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
    public class BusRouteService
    {
        public static List<BusRouteModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusRouteModel>>(BusOwnerDataAccessFactory.BusRouteFirstDataAccess().Get());
            return data;
        }
        public static BusRouteModel Get(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRouteModel>(BusOwnerDataAccessFactory.BusRouteFirstDataAccess().Get(id));
            return data;
        }
        public static List<BusRouteModel> GetBusList(int id)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRoute, BusRouteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusRouteModel>>(BusOwnerDataAccessFactory.BusRouteSecondDataAccess().Buslist(id));
            return data;
        }
        public static void Add(BusRouteModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRouteModel, BusRoute>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(obj);
            BusOwnerDataAccessFactory.BusRouteFirstDataAccess().Add(data);
        }
        public static void Edit(BusRouteModel obj)
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusRouteModel, BusRoute>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(obj);
            BusOwnerDataAccessFactory.BusRouteFirstDataAccess().Edit(data);
        }
        public static void Delete(int i)
        {

            BusOwnerDataAccessFactory.BusRouteFirstDataAccess().Delete(i);
        }
    }
}
