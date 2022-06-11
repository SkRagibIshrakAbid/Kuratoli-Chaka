using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CartModel
    {
        public int CR_Id { get; set; }
        public Nullable<int> U_Id { get; set; }
        public Nullable<int> B_Id { get; set; }
        public string Stopage { get; set; }
        public Nullable<int> BS_Fair { get; set; }
    }
}
