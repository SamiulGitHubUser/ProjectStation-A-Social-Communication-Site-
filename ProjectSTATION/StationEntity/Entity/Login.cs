using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Login
    {
        public int LoginID{ get; set; }
        public DateTime LastLogin { get; set; }
        public int FailureAttempt { get; set; }
        public User User { get; set; }
    }
}
