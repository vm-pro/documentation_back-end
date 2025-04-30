using Documentation_back_end.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Documentation_back_end.Data
{
    public class HostRepo: IHostRepo
    {
        private readonly AppDbContext _context;
        public HostRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Domain.Host>> GetAll()
        {
            return await _context.Hosts.ToListAsync();
        }
        public async Task<IActionResult> Add(string name)
        {
            var host = new Domain.Host
            {
                name = name
            };
            _context.Hosts.Add(host);
            var response = await _context.SaveChangesAsync();
            if (response > 0)
            {
                return new OkObjectResult(host);
            }
            else
            {
                return new BadRequestObjectResult("Failed to add host");
            }
        }
        public async Task<IActionResult>Delete (int id)
        {
            var host = await _context.Hosts.FindAsync(id);
            if (host == null)
            {
                return new NotFoundObjectResult("Host not found");
            }
            _context.Hosts.Remove(host);
            var response = await _context.SaveChangesAsync();
            if (response > 0)
            {
                return new OkObjectResult(host);
            }
            else
            {
                return new BadRequestObjectResult("Failed to delete host");
            }
        }

    }
}
