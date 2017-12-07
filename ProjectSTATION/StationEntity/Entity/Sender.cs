using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Sender : Entity
    {
        //[Key]
        //public int SendID { get; set; }
        public string MessageDescription { get; set; }
        public string ImageURL { get; set; }
        public DateTime SendTime { get; set; }
        public string MessageState { get; set; }
        public User User { get; set; }
    }
}
