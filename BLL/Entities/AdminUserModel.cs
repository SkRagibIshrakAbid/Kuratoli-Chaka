using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AdminUserModel
    {
        public int U_Id { get; set; }
        public string U_UserName { get; set; }
        public string U_Password { get; set; }
        public string U_Phone { get; set; }
        public string U_Email { get; set; }
        public string U_Address { get; set; }
        public string U_Gender { get; set; }
        public string U_DateofBirth { get; set; }
        public string U_Role { get; set; }
        public string U_Status { get; set; }

        //public virtual ICollection<BusInfo> BusInfoes { get; set; }
        //public virtual ICollection<BusInfo> BusInfoes1 { get; set; }
       // public virtual ICollection<Cart> Carts { get; set; }
       // public virtual ICollection<SoldTicket> SoldTickets { get; set; }
    }
}
