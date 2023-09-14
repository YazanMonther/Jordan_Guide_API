using Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceContract.DTO
{
    public class TrendingEventsResponse
    {

        public string? eventCity { get; set; }


        public string? eventName { get; set; }


        public string? eventCategory { get; set; }

        public string? eventDate { get; set; }

        public string? eventDateFinish { get; set; }

        public string? eventDescription { get; set; }

        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }

        public string? EventLocationDesc { get; set; }

    }

    public static class TredningEventsEx
    {
        public static TrendingEventsResponse TrendingEventsResponse(this TrendingEvents? events)
        {
            return new TrendingEventsResponse()
            {
                eventName = events?.eventName,
                eventCity = events?.eventCity,
                eventCategory = events?.eventCategory,
                eventDate = events?.eventDate.Value.Date.ToString("yyyy dddd- dd MMMM", new CultureInfo("ar-AE")),
                eventDateFinish= events?.eventDateFinish.Value.Date.ToString("yyyy dddd- dd MMMM", new CultureInfo("ar-AE")),
                Image1 = events?.Images?.Count > 0 ? events.Images[0].Image1 : null,
                Image2 = events?.Images?.Count > 0 ? events.Images[0].Image2 : null,
                Image3 = events?.Images?.Count > 0 ? events.Images[0].Image3 : null,
                Image4 = events?.Images?.Count > 0 ? events.Images[0].Image4 : null,
                eventDescription = events?.eventDescription,
                EventLocationDesc=events?.EventLocationDesc,
                
            };
        }
    }
}
