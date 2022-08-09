using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    internal interface ILibrariantRepository
    {
        List<User> SelectAllLibrariants();
        User SelectLibrariantById(int librariantId);
        User InsertLibrariant(User librariant);
        User UpdateLibrariant(int librariantId, User librariant);
        bool DeleteLibrariant(int librariantId);
    }
}
