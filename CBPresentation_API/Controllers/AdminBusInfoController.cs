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
    public class AdminBusInfoController : ApiController
    {
        [Route("api/admin/businfo/names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return AdminBusInfoService.GetNames();
        }

        [Route("api/admin/businfo/all")]
        [HttpGet]
        public List<AdminBusInfoModel> GetAll()
        {
            return AdminBusInfoService.Get();
        }

        [Route("api/admin/businfo/create")]
        [HttpPost]
        public void Add(AdminBusInfoModel u)
        {
            AdminBusInfoService.Add(u);
        }

        [Route("api/admin/businfo/update")]
        [HttpPost]
        public void Edit(AdminBusInfoModel u)
        {
            AdminBusInfoService.Edit(u);
        }

        [Route("api/admin/businfo/delete/{id}")]
        [HttpGet]
        public void Delete(int id)
        {
            AdminBusInfoService.Delete(id);
        }
    }
}
