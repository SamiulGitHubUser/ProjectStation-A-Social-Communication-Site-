using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class User: Entity
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
