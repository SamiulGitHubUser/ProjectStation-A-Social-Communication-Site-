using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationEntity
{
    public class UserProfile : Entity
    {
        //[Key]
        //public int UserID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+([._-][a-zA-Z0-9]+)?@[a-zA-Z0-9]{2,50}([.][a-z]{2,5})+$", ErrorMessage = "Inavlid Email, Ex: jhon.doe@xshop.com.bd")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+([._-][a-zA-Z0-9]+)?@[a-zA-Z0-9]{2,50}([.][a-z]{2,5})+$", ErrorMessage = "Inavlid Email, Ex: jhon.doe@xshop.com.bd")]
        public string LastName { get; set; }

        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePicURL { get; set; }
        public string CoverPicURL { get; set; }
        
    }
}
