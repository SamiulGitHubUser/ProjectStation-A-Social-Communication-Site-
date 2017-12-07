using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Post : Entity
    {
        //[Key]
        //public int PostID { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime UploadTime { get; set; }
        public string PostType { get; set; }
        public User User { get; set; }
    }
}
