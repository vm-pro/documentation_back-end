using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Service.Interfaces
{
    public interface IHostService
    {
        Task<IEnumerable<Domain.Host>> GetAll();
        Task<IActionResult> Add(string name);
        Task<IActionResult> Delete(int id);
    }
}
