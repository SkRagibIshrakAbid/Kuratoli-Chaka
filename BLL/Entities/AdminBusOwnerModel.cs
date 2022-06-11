using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AdminBusOwnerModel
    {
        public int O_Id { get; set; }
        public string O_UserName { get; set; }
        public string O_Password { get; set; }
        public string O_Phone { get; set; }
        public string O_Email { get; set; }
        public string O_Address { get; set; }
        public string O_Gender { get; set; }
        public string O_DateofBirth { get; set; }
        public string O_Role { get; set; }
    }
}
