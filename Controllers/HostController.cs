using Documentation_back_end.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Controllers
{
    public class HostController : Controller
    {

        public readonly ILogger<HostController> _logger;
        public readonly IHostService _hostService;

        public HostController(ILogger<HostController> logger, IHostService hostService)
        {
            _logger = logger;
            _hostService = hostService;
        }
        [AllowAnonymous]
        [HttpGet("getAll")]
        public async Task<IEnumerable<Domain.Host>> GetAll()
        {
            try
            {
                return await _hostService.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting all hosts.");
                return Enumerable.Empty<Domain.Host>();
            }
        }




    }
}