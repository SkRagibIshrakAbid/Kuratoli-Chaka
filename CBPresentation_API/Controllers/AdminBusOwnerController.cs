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
    public class AdminBusOwnerController : ApiController
    {
        [Route("api/admin/busowner/names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return AdminBusOwnerService.GetNames();
        }

        [Route("api/admin/busowner/all")]
        [HttpGet]
        public List<AdminBusOwnerModel> GetAll()
        {
            return AdminBusOwnerService.Get();
        }

        [Route("api/admin/busowner/create")]
        [HttpPost]
        public void Add(AdminBusOwnerModel u)
        {
            AdminBusOwnerService.Add(u);
        }

        [Route("api/admin/busowner/update")]
        [HttpPost]
        public void Edit(AdminBusOwnerModel u)
        {
            AdminBusOwnerService.Edit(u);
        }

        [Route("api/admin/busowner/delete/{id}")]
        [HttpGet]
        public void Delete(int id)
        {
            AdminBusOwnerService.Delete(id);
        }
    }
}
