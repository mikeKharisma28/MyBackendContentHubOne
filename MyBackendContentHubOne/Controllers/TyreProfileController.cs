using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBackendContentHubOne.Models;
using MyBackendContentHubOne.Services;

namespace MyBackendContentHubOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyreProfileController : ControllerBase
    {
        private readonly ILogger<TyreProfileController> _logger;
        private readonly IConfiguration _configuration;

        public TyreProfileController(ILogger<TyreProfileController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetTyreProfiles")]
        public async Task<IEnumerable<TyreProfile>> Get()
        {
            ITyreProfileServices tyreProfileSvc = new TyreProfileServices(_configuration);
            return await tyreProfileSvc.GetTyreProfilesAsync();
        }

    }
}
