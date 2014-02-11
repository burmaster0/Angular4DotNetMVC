using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMvc.Models.Account;
using System.Net;
using System.Web.Http;
using System.Net.Http;

namespace Angular4DotNetMvc.Controllers
{
    public class AccountController : ApiController
    {
        public HttpResponseMessage Post(HttpRequestMessage request, StudentVm student)
        {
            if (ModelState.IsValid)
            {
                //_studentRegistrationService.Register(student);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
        }

        private object GetErrorMessages()
        {
            return ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
        }
    }
}
