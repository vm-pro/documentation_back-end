using Documentation_back_end.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Data.Interfaces
{
    public interface IHostRepo
    {
        Task<IEnumerable<Domain.Host>> GetAll();
        Task<IEnumerable<HostDto>> GetAllForGrid();
        Task<Domain.Host> GetById(int id);
        Task<IActionResult> Update(Domain.Host host);
        Task<IActionResult> Add(Domain.Host newHost);
        Task<IActionResult> Delete(int id);
    }
}
