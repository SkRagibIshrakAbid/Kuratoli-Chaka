using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;

namespace BLL.Services
{
    public class BusOwnerBusSearchService
    {
        public static List<BusModel> GetBusList(string id) //has issues with irepo //solved
        {
            var config = new MapperConfiguration(c => c.CreateMap<BusInfo, BusModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BusModel>>(BusOwnerDataAccessFactory.BusSearchDataAccess().Buslist(id));
            return data;
        }
    }
}
