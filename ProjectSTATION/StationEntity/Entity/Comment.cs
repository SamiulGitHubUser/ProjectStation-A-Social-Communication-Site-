using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class Comment : Entity
    {
        //[Key]
        //public int CommentID { get; set; }
        public string Description { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentState { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
