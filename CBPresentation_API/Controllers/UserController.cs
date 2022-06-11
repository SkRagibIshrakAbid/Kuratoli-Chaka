using BLL.Services;
using CBPresentation_API.Auth;
using DAL.Database;
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
    public class UserController : ApiController
    {
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {

            var st = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        //[CustomeAuth]
        [Route("api/user/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var st = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/user/Add")]
        [HttpPost]
        public HttpResponseMessage Add(User data)
        {
            if (data ==null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Can not Create user");
            }
            else
            {
                var st = UserService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, "User Created");
            }


        }

        [Route("api/delete/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var st = UserService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.OK, "User Deleted");

        }

        [Route("api/edit/user")]
        [HttpPost]
        public HttpResponseMessage Edit(User data)
        {
            var st = UserService.Update(data);
            return Request.CreateResponse(HttpStatusCode.OK, "User Edited"); ;

        }

        [Route("api/cart/history/{id}")]
        [HttpGet]
        public HttpResponseMessage Phistory(int id)
        {
            var st = UserService.History(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);

        }

        
        [Route("api/user/busrouts")]
        [HttpGet]
        public HttpResponseMessage BusRouts()
        {
            var st = BusRouteService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }


        [Route("api/delete/cart/{id}")]
        [HttpGet]
        public HttpResponseMessage CartDelete(int id)
        {
            var st = CartService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted From Cart");

        }

    }
}
