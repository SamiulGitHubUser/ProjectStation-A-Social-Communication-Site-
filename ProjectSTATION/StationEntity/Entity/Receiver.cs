using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Receiver : Entity
    {
        //[Key]
        //public int ReceiveID { get; set; }
        public string MessageDescription { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReceiveTime { get; set; }
        public string MessageState { get; set; }
        public User user { get; set; }
    }
}
