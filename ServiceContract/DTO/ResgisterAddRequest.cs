using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class ResgisterAddRequest
    {
        [Required(ErrorMessage = "Person Name Cant be blank")]
        public string PersonName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Cant be blank")]
        [EmailAddress]
        [Remote(action: "IsEmailAllreadyRegister", controller: "Account", ErrorMessage = "Email is already Exist")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Cant be blank")]
        [Phone]
        [Remote(action: "IsPhoneNumberAllreadyRegister", controller: "Account", ErrorMessage = "Email is already Exist")]
        public string PhoneNumer { get; set; } = string.Empty;


        [Required(ErrorMessage = "Password Cant be blank")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password Cant be blank")]
        [Compare("Password" ,ErrorMessage ="Password and confirm password do not match")]
        public string ConfimaPassword { get; set; } = string.Empty;

        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{dd\\MM\\yyyy}")]
        public DateTime BirthDay { get; set; }
    }

}
