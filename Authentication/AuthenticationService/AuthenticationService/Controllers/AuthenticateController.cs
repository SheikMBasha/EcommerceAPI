using AuthenticationService.BLL.Interfaces;
using AuthenticationService.Models;
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

        [AcceptVerbs("GET")]
        [HttpGet]
        public IHttpActionResult CheckApi(string input)
        {
            return Json(new { success = true });
        }


        [HttpPost]
        [ActionName("Login")]
        public IHttpActionResult Login([FromBody]Credentials credentials )
        {
            string username = credentials.userName;
            string password = credentials.password;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return Unauthorized();
            }
            if (_authenticateBll.isAuthenticated(username, password))
            {
                return Json(new { Success = true });
            }
            return BadRequest("Internal server error");
        }
    }
}
