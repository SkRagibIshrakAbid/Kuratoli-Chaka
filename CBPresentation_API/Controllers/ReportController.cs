using BLL.Services;
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
    //[EnableCors("req accept from domain", "header", "what type of method request")]
    [EnableCors("*", "*", "*")]
    public class ReportController : ApiController
    {
        [Route("api/cart/bus/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {

            var st = CartService.Bus(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/cart/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var st = CartService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/AddtoCart")]    // id = bus id
        [HttpPost]
        public HttpResponseMessage AddtoCart(Cart data)
        {
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Can not Add to Cart");
            }
            else
            {
                CartService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, "Added to Cart");
            }


        }


    }
}
