using Documentation_back_end.Domain.Dto;
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
        [AllowAnonymous]
        [HttpGet("getAllForGrid")]
        public async Task<IEnumerable<HostShortDto>> GetAllForGrid()
        {
            try
            {
                return await _hostService.GetAllForGrid();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting all hosts for grid.");
                return Enumerable.Empty<HostShortDto>();
            }
        }

        [AllowAnonymous]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]HostAdding host)
        {
            try
            {
                var result = await _hostService.Add(host);
                if (result is OkObjectResult okResult)
                {
                    return okResult;
                }
                else if (result is BadRequestObjectResult badRequestResult)
                {
                    return badRequestResult;
                }
                else
                {
                    return StatusCode(500, "Internal server error");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a host.");
                return StatusCode(500, "Internal server error");

            }

        }
        [AllowAnonymous]
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _hostService.Delete(id);
                if (result is OkObjectResult okResult)
                {
                    return okResult;
                }
                else if (result is NotFoundObjectResult notFoundResult)
                {
                    return notFoundResult;
                }
                else
                {
                    return StatusCode(500, "Internal server error");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting a host.");
                return StatusCode(500, "Internal server error");
            }
        }




    }
}