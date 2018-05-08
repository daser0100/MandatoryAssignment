using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT.Models
{
    public class News
    {
        public int ID { get; set; }
        public int RoomNumber { get; set; }
        public string FrontName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string EMail { get; set; }
        public int PhoneNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
    }
}
