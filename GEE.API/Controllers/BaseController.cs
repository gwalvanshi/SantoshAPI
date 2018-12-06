using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GEE.Common;

namespace GEE.API.Controllers
{
    public class BaseController : ApiController
    {
        public HttpResponseMessage SendErrorResponse(Exception ex)
        {
            MyLogger.Error("error", ex);
            return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        }
    }
}
