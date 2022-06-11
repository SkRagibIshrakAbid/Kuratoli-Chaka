using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using DAL;
using DAL.Database;

namespace BLL.Services
{
    public class SupervisorService
    {
        public static UserModel Get(int id)
        {
            var us = UserDataAccessFectory.SuperDataAccess().Get(id);
            var u = new UserModel()
            {
                U_Id = us.U_Id,
                U_UserName = us.U_UserName,
                U_Password = us.U_Password,
                U_Phone = us.U_Phone,
                U_Email = us.U_Email,
                U_Address = us.U_Address,
                U_Gender = us.U_Gender,
                U_DateofBirth = us.U_DateofBirth,
                U_Role = us.U_Role,
                U_Status = us.U_Status
            };
            return u;
        }

        public static UserModel Add(User obj)
        {
            var us = UserDataAccessFectory.SuperDataAccess().Add(obj);
            var u = new UserModel()
            {
               // U_Id = us.U_Id,
                U_UserName = us.U_UserName,
                U_Password = us.U_Password,
                U_Phone = us.U_Phone,
                U_Email = us.U_Email,
                U_Address = us.U_Address,
                U_Gender = us.U_Gender,
                U_DateofBirth = us.U_DateofBirth,
                U_Role = us.U_Role,
                U_Status = us.U_Status
            };
            return u;
        }
    }
}
