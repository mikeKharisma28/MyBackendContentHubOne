using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBackendContentHubOne.Models;
using MyBackendContentHubOne.Services;

namespace MyBackendContentHubOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyreRimController : ControllerBase
    {
        private readonly ILogger<TyreRimController> _logger;
        private readonly IConfiguration _configuration;

        public TyreRimController(ILogger<TyreRimController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetTyreRims")]
        public async Task<IEnumerable<TyreRim>> Get()
        {
            ITyreRimServices tyreRimSvc = new TyreRimServices(_configuration);
            return await tyreRimSvc.GetTyreRimsAsync();
        }
    }
}
