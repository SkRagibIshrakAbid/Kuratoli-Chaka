using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CBPresentation_API.Auth
{
    public class BusOwnerCustomAuth : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authheader = actionContext.Request.Headers.Authorization;
            if (authheader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "No token found");
            }
            else
            {
                if (BusOwnerAuthService.IsAuthenticated(authheader.ToString()))
                {
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "The token is expired");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}