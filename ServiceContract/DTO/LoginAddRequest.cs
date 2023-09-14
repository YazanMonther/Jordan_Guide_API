using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceContract.DTO
{
    public  class LoginAddRequest
    {
        [Required(ErrorMessage ="Email cant be blank")]
        [EmailAddress(ErrorMessage ="Email should be in a proper email address format ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cant be blank")]
       
        public string Password { get; set; }
    }
}
