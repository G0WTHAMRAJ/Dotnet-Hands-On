using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
       private static IList<String> _car = new List<String>();
        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _car.ToList().ToArray();
            //return new string[] { "Benz", "Lambo","Porche","Toyoto","Audi","BMW" };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _car[id];
            //return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _car.Add(value);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _car[id] = value;
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
       public ActionResult Delete(int id)
        {
             _car.RemoveAt(id);
            return NoContent();
        }
    }
}
