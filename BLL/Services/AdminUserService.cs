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
    public class AdminUserService
    {
        public static List<AdminUserModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, AdminUserModel>();
            });
            var mapper = new Mapper(config);
            var udata = AdminUserDataAccessFactory.AdminUserDataAccess();
            var data = mapper.Map<List<AdminUserModel>>(udata.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var udata = AdminUserDataAccessFactory.AdminUserDataAccess();
            var data = udata.Get().Select(e => e.U_UserName).ToList();
            return data;
        }
        public static void Add(AdminUserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminUserModel, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            AdminUserDataAccessFactory.AdminUserDataAccess().Add(data);
        }
        public static void Edit(AdminUserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminUserModel, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            AdminUserDataAccessFactory.AdminUserDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            AdminUserDataAccessFactory.AdminUserDataAccess().Delete(id);
        }
    }
}
