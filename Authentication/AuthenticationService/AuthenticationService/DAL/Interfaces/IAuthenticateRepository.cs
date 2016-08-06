using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.DAL.Interfaces
{
    public interface IAuthenticateRepository
    {
        string Authenticate(string userName);
    }
}
