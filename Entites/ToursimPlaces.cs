namespace Entites
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TourismPlaces")]
    public class TourismPlaces
    {

        [Key]
        public int tourismPlaceId { get; set; }

        public string? tourismCity { get; set; }

        public string? tourismName { get; set; }

        public string? tourismCategory { get; set; }

        public string? tourismDescription { get; set; }
        public string? tourismLocation { get; set; }

        public string? tourismPrice { get; set; }
        public string? CitizenPrice { get; set; }
       // [Range(1, 5)]
        public string? tourismRating { get; set; }

        public string? main_Image { get; set; }

        public List<Images>? images { get; set; }

        public string? tourismLocationDesc { get; set; }

        public string? SundayTime { get; set; }
        public string? MondayTime { get; set; }
        public string? TuesdayTime { get; set; }
        public string? WednesdayTime { get; set; }
        public string? ThursdayTime { get; set; }
        public string? FridayTime { get; set; }
        public string? SaturdayTime { get; set; }


    }
}
