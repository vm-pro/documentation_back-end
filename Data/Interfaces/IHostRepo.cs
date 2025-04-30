using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Data.Interfaces
{
    public interface IHostRepo
    {
        Task<IEnumerable<Domain.Host>> GetAll();
        Task<IActionResult> Add(string name);
        Task<IActionResult> Delete(int id);
    }
}
