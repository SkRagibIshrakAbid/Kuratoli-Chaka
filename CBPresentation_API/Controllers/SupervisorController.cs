using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.Services;
using CBPresentation_API.Auth;
using DAL.Database;

namespace CBPresentation_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SupervisorController : ApiController
    {
       // [SuperAuth]
        [Route("api/supervisor/{id}/")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {

            var st = SupervisorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/add/supervisor/")]
        [HttpPost]
        public HttpResponseMessage AddSuper(User obj)
        {

            var st = SupervisorService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/assignedbus/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAssignedBus(int id)
        {

            var b = AssignedUpdateBusService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, b);
        }

        [Route("api/updateseat/{id}/{s}")]
        [HttpPost]
        public HttpResponseMessage UpdateAvailableSeat(int id, int s)
        {

            var st = AssignedUpdateBusService.UpdateSeat(id, s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated AvailableSeat");
        }
    }
}
