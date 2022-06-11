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
    public class AdminBusRouteService
    {
        public static List<AdminBusRouteModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusRoute, AdminBusRouteModel>();
            });
            var mapper = new Mapper(config);
            var udata = AdminUserDataAccessFactory.AdminBusRouteDataAccess();
            var data = mapper.Map<List<AdminBusRouteModel>>(udata.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var udata = AdminUserDataAccessFactory.AdminBusRouteDataAccess();
            var data = udata.Get().Select(e => e.BR_Start).ToList();
            return data;
        }
        public static void Add(AdminBusRouteModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusRouteModel, BusRoute>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(u);
            AdminUserDataAccessFactory.AdminBusRouteDataAccess().Add(data);
        }
        public static void Edit(AdminBusRouteModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusRouteModel, BusRoute>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusRoute>(u);
            AdminUserDataAccessFactory.AdminBusRouteDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            AdminUserDataAccessFactory.AdminBusRouteDataAccess().Delete(id);
        }
    }
}
