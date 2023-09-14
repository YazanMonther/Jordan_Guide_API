using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class ApplicationUserRequest
    {

        public Guid Id { get; set; }
        public string? PersonName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd\\MM\\yyyy}")]
        public DateTime BirthDay { get; set; }
    }

    //public static class ExtentionApplicationUser
    //{

    //    public static 
    //}
}
