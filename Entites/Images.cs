using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entites
{
    [Table("Images")]
    public class Images
    {
        [Key]
        public int id { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }

        [ForeignKey("TourismPlaces")]
        public int? tourismPlaceId { get; set; }
        public TourismPlaces? tourism { get; set; }

        [ForeignKey("TrendingEvents")]
        public int? tredndingEventsId { get; set; }
        public TrendingEvents? trending { get; set; }
        
    }
 //   dotnet ef migrations add InitDatabase1233 --project Entites -s TourismApi -c ApplicationDbContext --verbose
}
//dotnet ef database update --connection "Server=tcp:tourismapp-server.database.windows.net,1433;Initial Catalog=TourismDb;Persist Security Info=False;User ID=yazan;Password=Abeer5abeer;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"  --project "C:\Users\DELL\source\repos\TourimApi\TourismApi\TourismApi.csproj"

//dotnet ef database update --connection "Server=tcp:tourismapp-server.database.windows.net,1433;Initial Catalog=TourismDb;Persist Security Info=False;User ID=yazan;Password=Abeer5abeer;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" --project "C:\Users\DELL\source\repos\TourimApi\TourismApi\TourismApi.csproj" --migration InitDatabase1233 -o C:\Users\DELL\source\repos\TourimApi\Entites\Migrations\20230909105809_InitDatabase1233.cs
