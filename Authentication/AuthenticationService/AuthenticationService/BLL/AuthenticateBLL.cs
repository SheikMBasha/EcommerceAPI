﻿using AuthenticationService.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationService.BLL
{
    public class AuthenticateBLL : IAuthenticateBLL
    {
        public bool isAuthenticated(string userName, string Password)
        {
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(Password))
            {
                if(userName == "abc" && Password == "abc")
                {
                    return true;
                }
            }
            return false;
        }
    }
}