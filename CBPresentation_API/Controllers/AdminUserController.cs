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
    public class AdminUserController : ApiController
    {
        [Route("api/admin/user/names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return AdminUserService.GetNames();
        }

        [Route("api/admin/user/all")]
        [HttpGet]
        public List<AdminUserModel> GetAll()
        {
            return AdminUserService.Get();
        }

        [Route("api/admin/user/create")]
        [HttpPost]
        public void Add(AdminUserModel u)
        {
            AdminUserService.Add(u);
        }

        [Route("api/admin/user/update")]
        [HttpPost]
        public void Edit(AdminUserModel u)
        {
            AdminUserService.Edit(u);
        }

        [Route("api/admin/user/delete/{id}")]
        [HttpGet]
        public void Delete(int id)
        {
            AdminUserService.Delete(id);
        }

    }
}
