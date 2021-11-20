using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class UserRegClass
    {
        [Key]
        public int Id{ get; set; }

        [Required]//(ErrorMessage ="Please Enter your First Name")]
        [Display(Name = "First Name")]
        public string User_Fname { get; set; }

        [Required]//(ErrorMessage = "Please Enter your Surname")]
        [Display(Name = "Surname")]
        public string User_Lname { get; set; }

        [Required]//(ErrorMessage = "Please Enter your Email Address")]
        [Display(Name = "Email Address")]
        public string User_Email { get; set; }

        [Required]//(ErrorMessage = "Please Enter your preffered User Name (ususally your First Name)")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]//(ErrorMessage = "Please Enter the password you want to use")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Required]//(ErrorMessage = "Please Enter Password again")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password does not match")]
        [Display(Name = "Confirm Password")]
        public string ConPass { get; set; }


    }
}
