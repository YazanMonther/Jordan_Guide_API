using Microsoft.AspNetCore.Mvc;
using ServiceContract.DTO;
using ServiceContract;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Entites;
namespace TourismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursimController : ControllerBase
    {
        private readonly ITourismService _tourismServices;

        public ToursimController(ITourismService tourismServices)
        {
            _tourismServices = tourismServices;
        }

        // GET: api/<ToursimController>
        [HttpGet]
        public  async Task<List<TourismPlaceResponse>?> GetTourismPlaces()
        {
           return await _tourismServices.GetTourismPlaces();
        }

        // GET api/<ToursimController>/5
        [HttpGet("{id}")]
        public async Task<TourismPlaceResponse?> GetTourismPlacesByID(int? id)
        {
            TourismPlaceResponse? t= await _tourismServices.GetTourismPlacesByID(id);
            return t;
        }
        // GET api/<ToursimController>/السياحة الدينية
        [HttpGet("category/{category}")]
        public async Task<List<TourismPlaceResponse >?> GetTourismPlacesByCategory(string? category)
        {
            return await _tourismServices.GetTourismPlacesByCategory(category);
        }

        // GET api/<ToursimController>/عمان
        [HttpGet("cities/{city}")]
        public async Task<List<TourismPlaceResponse>?> GetTourismPlacesByCity(string? city)
        {
            return await _tourismServices.GetTourismPlacesByCity(city);
        }

        // GET api/<ToursimController>/DEC  
        [HttpGet("rank/{rank}")]
        public async Task<List<TourismPlaceResponse>?> GetTourismPlacesByRank(string? rank)
        {
            return await _tourismServices.GetTourismPlacesByRank(rank);
        }

        // POST api/<ToursimController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ToursimController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ToursimController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
