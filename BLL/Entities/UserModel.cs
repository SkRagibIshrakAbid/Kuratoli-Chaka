using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class UserModel
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
    }
}
