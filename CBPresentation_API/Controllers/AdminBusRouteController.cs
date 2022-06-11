using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CBPresentation_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminBusRouteController : ApiController
    {
        [Route("api/admin/busroute/names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return AdminBusRouteService.GetNames();
        }

        [Route("api/admin/busroute/all")]
        [HttpGet]
        public List<AdminBusRouteModel> GetAll()
        {
            return AdminBusRouteService.Get();
        }

        [Route("api/admin/busroute/create")]
        [HttpPost]
        public void Add(AdminBusRouteModel u)
        {
            AdminBusRouteService.Add(u);
        }

        [Route("api/admin/busroute/update")]
        [HttpPost]
        public void Edit(AdminBusRouteModel u)
        {
            AdminBusRouteService.Edit(u);
        }

        [Route("api/admin/busroute/delete/{id}")]
        [HttpGet]
        public void Delete(int id)
        {
            AdminBusRouteService.Delete(id);
        }
    }
}
