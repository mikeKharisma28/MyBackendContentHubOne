using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBackendContentHubOne.Models;
using MyBackendContentHubOne.Services;

namespace MyBackendContentHubOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyreController : ControllerBase
    {
        private readonly ILogger<TyreController> _logger;
        private readonly IConfiguration _configuration;

        public TyreController(ILogger<TyreController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        //[HttpGet(Name = "GetAllTyres")]
        //public IEnumerable<Tyres> GetTyres()
        //{
            
        //}

        [HttpGet(Name = "GetTyres")]
        public async Task<IEnumerable<Tyre>> Get()
        {
            ITyreServices tyreSvc = new TyreServices(_configuration);
            return await tyreSvc.GetAllTyresAsync();
        }
    }
}
