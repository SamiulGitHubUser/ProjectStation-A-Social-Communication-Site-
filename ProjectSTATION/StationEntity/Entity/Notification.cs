using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Notification : Entity
    {
        //[Key]
        //public int NotificationID { get; set; }
        public string Description { get; set; }
        public string NotificationType { get; set; }
        public string NotifiedTime { get; set; }
        public string NotifiedPlace { get; set; }
        public string NotificationState { get; set; }
        public User user { get; set; }
    }
}
