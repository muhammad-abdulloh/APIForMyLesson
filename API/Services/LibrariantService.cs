using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services  
{
    public class LibrariantService : ILibrariantService
    {
        public User AddLibrariant(User librariant)
        {
            throw new NotImplementedException();
        }

        public User ModifyLibrariant(long librariantId, User librariant)
        {
            throw new NotImplementedException();
        }

        public User RemoveLibrariant(long librariantId)
        {
            throw new NotImplementedException();
        }

        public User RetrieveLibrariant(int librariantId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> RetrieveLibrariants(string name)
        {
            throw new NotImplementedException();
        }
    }
}
