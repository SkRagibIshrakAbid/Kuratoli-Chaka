using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AdminBusRouteModel
    {
        public int BR_Id { get; set; }
        public Nullable<int> BR_BId { get; set; }
        public string BR_Start { get; set; }
        public string BR_End { get; set; }
        public string BR_Stopage1 { get; set; }
        public string BR_Stopage2 { get; set; }
        public string BR_Stopage3 { get; set; }
        public string BR_Time { get; set; }
        public Nullable<int> BR_FairInS1 { get; set; }
        public Nullable<int> BR_FairInS2 { get; set; }
        public Nullable<int> BR_FairInS3 { get; set; }

       // public virtual BusInfo BusInfo { get; set; }
    }
}
