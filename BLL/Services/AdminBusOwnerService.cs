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
    public class AdminBusOwnerService
    {
        public static List<AdminBusOwnerModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusOwner, AdminBusOwnerModel>();
            });
            var mapper = new Mapper(config);
            var udata = AdminUserDataAccessFactory.AdminBusOwnerDataAccess();
            var data = mapper.Map<List<AdminBusOwnerModel>>(udata.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var udata = AdminUserDataAccessFactory.AdminBusOwnerDataAccess();
            var data = udata.Get().Select(e => e.O_UserName).ToList();
            return data;
        }
        public static void Add(AdminBusOwnerModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusOwnerModel, BusOwner>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusOwner>(u);
            AdminUserDataAccessFactory.AdminBusOwnerDataAccess().Add(data);
        }
        public static void Edit(AdminBusOwnerModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminBusOwnerModel, BusOwner>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BusOwner>(u);
            AdminUserDataAccessFactory.AdminBusOwnerDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            AdminUserDataAccessFactory.AdminBusOwnerDataAccess().Delete(id);
        }
    }
}
