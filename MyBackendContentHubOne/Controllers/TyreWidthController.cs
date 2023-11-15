using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBackendContentHubOne.Models;
using MyBackendContentHubOne.Services;

namespace MyBackendContentHubOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyreWidthController : ControllerBase
    {
        private readonly ILogger<TyreWidthController> _logger;
        private readonly IConfiguration _configuration;

        public TyreWidthController(ILogger<TyreWidthController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetTyreWidths")]
        public async Task<IEnumerable<TyreWidth>> Get()
        {
            ITyreWidthServices tyreWidthSvc = new TyreWidthServices(_configuration);
            return await tyreWidthSvc.GetTyreWidthsAsync();
        }
    }
}
