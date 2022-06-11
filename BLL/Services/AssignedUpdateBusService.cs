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
   public class AssignedUpdateBusService
    {
        public static BusModel Get(int id)
        {
            var bs = SuperDataAccessFactory.BusDataAccess().AssignedBus(id);
            var b = new BusModel()
            {
                B_Id = bs.B_Id,
                B_Name = bs.B_Name,
                B_NoPlate = bs.B_NoPlate,
                B_Type = bs.B_Type,
                B_Route = bs.B_Route,
                B_Time = bs.B_Time,
                B_Fair = bs.B_Fair,
                B_AvailableSeat = bs.B_AvailableSeat,
                B_OwnedBy = bs.B_OwnedBy,
                B_SId = bs.B_SId,
                B_Status = bs.B_Status
            };
            return b;
        }

        public static BusModel UpdateSeat(int id, int s)
        {
            var bs = SuperDataAccessFactory.BusDataAccess().UpdateSeat(id, s);
            var b = new BusModel()
            {
                B_Id = bs.B_Id,
                B_Name = bs.B_Name,
                B_NoPlate = bs.B_NoPlate,
                B_Type = bs.B_Type,
                B_Route = bs.B_Route,
                B_Time = bs.B_Time,
                B_Fair = bs.B_Fair,
                B_AvailableSeat = bs.B_AvailableSeat,
                B_OwnedBy = bs.B_OwnedBy,
                B_SId = bs.B_SId,
                B_Status = bs.B_Status
            };
            return b;
        }

    }
}
