using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class RentedBook
    {
        public int RentId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime RentAt { get; set; }
        public DateTime ReturnAt { get; set; }
        public bool IsReturned { get; set; }
    }
}
