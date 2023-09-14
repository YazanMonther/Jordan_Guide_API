using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using ServiceContract.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendingEventsController : ControllerBase
    {
        private readonly ITrendingEventsServices trending;

        public TrendingEventsController(ITrendingEventsServices trendingEventsServices) 
        {
            trending =trendingEventsServices;
        
        }

        // GET: api/<TrendingEventsController>
        [HttpGet]
        public async Task<IEnumerable<TrendingEventsResponse>?> Get()
        {
            return await trending.GetTrendingEvents();
        }

        // GET api/<TrendingEventsController>/5
        [HttpGet("{city}")]
        public async Task<IEnumerable<TrendingEventsResponse>?> GetVyCityName(string city)
        {
            return await trending.GetTrendingEventsByCityName(city) ;
        }

        //// POST api/<TrendingEventsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<TrendingEventsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TrendingEventsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
