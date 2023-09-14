using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    [Table("TrendingEvents")]
    public class TrendingEvents
    {
        [Key]

        public int eventId { get; set; }


        public string? eventCity { get; set; }


        public string? eventName { get; set; }

        public string? eventRating { get; set; }

        public string? eventCategory { get; set; }

        public DateTime? eventDate { get; set; }


        public DateTime? eventDateFinish { get; set; } 

        public string? eventDescription { get; set; }

        public List<Images> Images { get; set; }

        public string? EventLocation { get; set; }

        public string? EventLocationDesc { get; set; }

    }
}
