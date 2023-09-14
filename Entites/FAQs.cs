using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    [Table("FAQs")]
    public class FAQs
    {

        [Key]
        public int QuestionId { get; set; }
       

        public string? Question { get; set; }


        public string? Answer { get;set; }


    }
}
