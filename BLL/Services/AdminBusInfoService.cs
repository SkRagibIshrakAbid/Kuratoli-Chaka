using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using DAL.Repo;

namespace BLL.Services
{
    public class AdminBusInfoService
    {
        public static List<AdminBusInfoModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusInfo, AdminBusInfoModel>();
            });
            var mapper = new Mapper(config);
            var udata = AdminUserDataAccessFactory.AdminBusInfoDataAccess();
            var data = mapper.Map<List<AdminBusInfoModel>>(udata.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var udata = AdminUserDataAccessFactory.AdminBusInfoDataAccess();
            var data = udata.Get().Select(e => e.B_Name).ToList();
            return data;
        }
        public static void Add(AdminBusInfoModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusInfoModel, BusInfo>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusInfo>(u);
            AdminUserDataAccessFactory.AdminBusInfoDataAccess().Add(data);
        }
        public static void Edit(AdminBusInfoModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusInfoModel, BusInfo>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusInfo>(u);
            AdminUserDataAccessFactory.AdminBusInfoDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            AdminUserDataAccessFactory.AdminBusInfoDataAccess().Delete(id);
        }
    }
}
