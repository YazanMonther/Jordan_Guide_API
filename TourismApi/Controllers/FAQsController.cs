using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using ServiceContract.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController : ControllerBase
    {
        private readonly IFAQsService fA;

        public FAQsController(IFAQsService fA)
        {
            this.fA = fA;
        }


        // GET: api/<FAQsController>
        [HttpGet]
        public async Task<IEnumerable<FAQsResponse>?> Get()
        {
            return await  fA.GetAllFAQs();
        }

        // GET api/<FAQsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<FAQsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<FAQsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FAQsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
