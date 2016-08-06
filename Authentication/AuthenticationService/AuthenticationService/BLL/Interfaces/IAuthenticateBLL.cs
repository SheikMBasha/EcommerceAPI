using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.BLL.Interfaces
{
    public interface IAuthenticateBLL
    {
        bool isAuthenticated(string userName, string Password);

    }
}
