using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserDetails.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
       
        [Required(ErrorMessage = "UserName Required")]
        public String UserName { get; set; }

       
        public String Password { get; set; }
        
       
        [Display(Name = "Confirm Password")]
        public String ConfirmPassword { get; set; }
       
        
        [Display(Name = "Full Name")]
        public String Name { get; set; }
        
        //We are also implementing Regular expression to check if email is valid like a1@test.com
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public String EmailId { get; set; }
       
        
        [Display(Name = "PinCode")]
        public short CityId { get; set; }
        
        
        public int PhoneNo { get; set; }
    }
}