using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public interface ILibrariantService
    {
        IEnumerable<User> RetrieveLibrariants(string name);
        User RetrieveLibrariant(int librariantId);
        User AddLibrariant(User librariant);
        User ModifyLibrariant(long librariantId, User librariant);
        User RemoveLibrariant(long librariantId);
    }
}
