using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCats()
        {
            var cats = new List<Cat>
            {
                new Cat
                {
                    Id = 1,
                    Name = "Felix",
                    Breed = "short",
                    Age = 1
                }
            };
            return Ok(cats);
        }
    }
}
