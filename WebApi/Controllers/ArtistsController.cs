using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Data.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ArtistsController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var races = await _db.Artists.ToListAsync();
            
            return Ok(races);
        }
    }
}