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
    public class CartService
    {
        public static CartModel Get(int id)
        {
            var ct = UserDataAccessFectory.CartDataAccess().Get(id);
            var c = new CartModel()
            {
               CR_Id = ct.CR_Id,
               U_Id = ct.U_Id,
               B_Id = ct.B_Id,
               Stopage = ct.Stopage,
               BS_Fair = ct.BS_Fair
            };
            return c;
        }

        public static List<CartModel> Get()
        {
            var ct = UserDataAccessFectory.CartDataAccess().Get();
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

        public static List<CartModel> Bus(int id)
        {
            var ct = UserDataAccessFectory.CartDataAccess().Buslist(id);
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

        public static CartModel Create(Cart obj)
        {
            var ct = UserDataAccessFectory.CartDataAccess().AddtoCart(obj);
            var c = new CartModel()
            {
                U_Id = ct.U_Id,
                B_Id = ct.B_Id,
                Stopage = ct.Stopage,
                BS_Fair = ct.BS_Fair
            };
            return c;
        }

        public static CartModel Remove(int id)
        {
            var us = UserDataAccessFectory.CartDataAccess().Delete(id);
            var c = new CartModel()
            {
                CR_Id = us.CR_Id,
                U_Id = us.U_Id,
                B_Id = us.B_Id,
                Stopage = us.Stopage,
                BS_Fair = us.BS_Fair
            };
            return c;
        }

    }
}
