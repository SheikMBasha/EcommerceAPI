using AuthenticationService.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace AuthenticationService.Controllers
{
    public class AuthenticateController : ApiController
    {

        private IAuthenticateBLL _authenticateBll;

        public AuthenticateController(IAuthenticateBLL authenticateBll)
        {
            _authenticateBll = authenticateBll; 
        }
        public IHttpActionResult Authenticate(string userName, string Password)
        {
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(Password))
            {
                return Unauthorized();
            }
            if(_authenticateBll.isAuthenticated(userName, Password))
            {
                return Json(new { Success = true });
            }
            return BadRequest("Internal server error");
        }
    }
}
