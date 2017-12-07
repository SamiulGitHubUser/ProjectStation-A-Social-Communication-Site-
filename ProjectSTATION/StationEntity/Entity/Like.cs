using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Like : Entity
    {
        //[Key]
        //public int LikeID { get; set; }
        public DateTime LikeTime { get; set; }
        public string LikeState { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
