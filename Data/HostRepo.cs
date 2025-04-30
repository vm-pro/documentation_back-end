using Documentation_back_end.Data.Interfaces;
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

    }
}
