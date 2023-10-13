using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBackendContentHubOne.Models;

namespace MyBackendContentHubOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyresController : ControllerBase
    {
        private readonly ILogger<TyresController> _logger;

        public TyresController(ILogger<TyresController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAllTyres")]
        public IEnumerable<Tyres> GetTyres()
        {
            
        }

        [HttpGet(Name = "GetTyreWidths")]
        public IEnumerable<TyreWidths> GetTyreWidths()
        {

        }
    }
}
