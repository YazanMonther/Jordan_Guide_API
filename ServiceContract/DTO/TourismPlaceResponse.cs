using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace ServiceContract.DTO
{
    public class TourismPlaceResponse
    {
        public string? tourismCity { get; set; }


        public string? tourismName { get; set; }


        public string? tourismCategory { get; set; }


        public string? tourismDescription { get; set; }

        public string? tourismLocation { get; set; }


        public string? tourismPrice { get; set; }

        public string? CitizenPrice { get; set; }
        // [Range(1, 5)]
        public string? tourismRating { get; set; }
        public string? Main_Image { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }

        public string? tourismLocationDesc { get; set; }

        public string? SundayTime { get; set; }
        public string? MondayTime { get; set; }
        public string? TuesdayTime { get; set; }
        public string? WednesdayTime { get; set; }
        public string? ThursdayTime { get; set; }
        public string? FridayTime { get; set; }
        public string? SaturdayTime { get; set; }
    }

    public static class TourismPlacsEx
    {
        public static TourismPlaceResponse TotourismPlaceResponse(this TourismPlaces? tourism)
        {

            return new TourismPlaceResponse()
            {
                tourismCategory = tourism?.tourismCategory,
                tourismCity = tourism?.tourismCity,
                tourismDescription = tourism?.tourismDescription,
                tourismLocation = tourism?.tourismLocation,
                tourismName = tourism?.tourismName,
                Image1 = tourism?.images?.Count > 0 ? tourism.images[0].Image1 : null,
                Image2 = tourism?.images?.Count > 0 ? tourism.images[0].Image2 : null,
                Image3 = tourism?.images?.Count > 0 ? tourism.images[0].Image3 : null,
                Image4 = tourism?.images?.Count > 0 ? tourism.images[0].Image4 : null,
                tourismPrice=tourism?.tourismPrice,
                tourismRating=tourism?.tourismRating,
                CitizenPrice=tourism?.CitizenPrice,
                Main_Image=tourism?.main_Image,
                tourismLocationDesc=tourism?.tourismLocationDesc,
                SundayTime=tourism?.SundayTime,
                MondayTime=tourism?.MondayTime,
                TuesdayTime=tourism?.TuesdayTime,
                ThursdayTime=tourism?.ThursdayTime,
                WednesdayTime=tourism?.WednesdayTime,
                SaturdayTime=tourism?.SaturdayTime,
                FridayTime=tourism?.FridayTime

            };
        }
    }
}

