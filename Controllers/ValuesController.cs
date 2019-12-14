using System.Threading.Tasks;
using CityGuide.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Values
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);

        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult> Get(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(v=>v.Id==id);
            return Ok(value);
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
