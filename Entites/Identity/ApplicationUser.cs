using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Identity
{
    public class ApplicationUser :IdentityUser<Guid>
    {
        public string? PersonName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd\\MM\\yyyy}")]
        public DateTime? BirthDay { get; set; }


    }

}