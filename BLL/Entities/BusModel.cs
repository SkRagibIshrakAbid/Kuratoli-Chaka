using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class BusModel
    {
        public int B_Id { get; set; }
        public string B_Name { get; set; }
        public string B_NoPlate { get; set; }
        public string B_Type { get; set; }
        public string B_Route { get; set; }
        public string B_Time { get; set; }
        public Nullable<int> B_Fair { get; set; }
        public Nullable<int> B_AvailableSeat { get; set; }
        public Nullable<int> B_OwnedBy { get; set; }
        public Nullable<int> B_SId { get; set; }
        public string B_Status { get; set; }
    }
}
