using Documentation_back_end.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Service.Interfaces
{
    public interface IHostService
    {
        Task<IEnumerable<Domain.Host>> GetAll();
        Task<IEnumerable<HostShortDto>> GetAllForGrid();
        Task<IActionResult> Add(HostAdding host);
        Task<IActionResult> Delete(int id);
    }
}
