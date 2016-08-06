using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthenticationService.Controllers
{
    public class AuthenticateController : ApiController
    {
        public IHttpActionResult Authenticate(string userName, string Password)
        {
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(Password))
            {
                return Unauthorized();
            }
            return BadRequest("Internal server error");
        }
    }
}
