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
    public class UserService
    {
        public static UserModel Get(int id)
        {
            var us = UserDataAccessFectory.UserDataAccess().Get(id);
            var u = new UserModel()
            {
                U_Id = us.U_Id,
                U_UserName = us.U_UserName,
                U_Password =us.U_Password,
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

        public static List<UserModel> Get()
        {
            var sts = UserDataAccessFectory.UserDataAccess().Get();
            List<UserModel> data = new List<UserModel>();
            foreach (var s in sts)
            {
                data.Add(new UserModel() 
                {
                    U_Id = s.U_Id,
                    U_UserName = s.U_UserName,
                    U_Password = s.U_Password,
                    U_Phone = s.U_Phone,
                    U_Email = s.U_Email,
                    U_Address = s.U_Address,
                    U_Gender = s.U_Gender,
                    U_DateofBirth = s.U_DateofBirth,
                    U_Role = s.U_Role,
                    U_Status = s.U_Status

                });

            }
            return data;
        }

        public static UserModel Create(User obj)
        {
            var us = UserDataAccessFectory.UserDataAccess().Add(obj);
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

        public static UserModel Remove(int id)
        {
            var us = UserDataAccessFectory.UserDataAccess().Delete(id);
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

        public static UserModel Update(User obj)
        {
            var us = UserDataAccessFectory.UserDataAccess().Edit(obj);
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

        public static List<CartModel> History(int id)
        {
            var ct = UserDataAccessFectory.CartDataAccess().Purchase(id);
            List<CartModel> data = new List<CartModel>();
            foreach (var s in ct)
            {
                data.Add(new CartModel()
                {
                    CR_Id = s.CR_Id,
                    U_Id = s.U_Id,
                    B_Id = s.B_Id,
                    Stopage = s.Stopage,
                    BS_Fair = s.BS_Fair

                });

            }
            return data;
        }
    }
}
