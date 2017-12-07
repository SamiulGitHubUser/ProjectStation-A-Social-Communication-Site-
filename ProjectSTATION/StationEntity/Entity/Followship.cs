using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Followship : Entity
    {
        //[Key]
        //public int FollowingID { get; set; }
        public string FollowerID { get; set; }
        public string FollowingID { get; set; }
        public string FollowshipState { get; set; }
        public DateTime FollowshipDate { get; set; }
        public User User { get; set; }
    }
}
