using Documentation_back_end.Data.Interfaces;
using Documentation_back_end.Domain;
using Documentation_back_end.Domain.Dto;
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
        public async Task<IEnumerable<HostDto>> GetAllForGrid()
        {
            return await _context.Hosts.Select(h => new HostDto
            {
                Id = h.Id,
                Name = h.Name,
                IsVirtual = h.IsVirtual,
                Os = h.Os,
                RamGb = h.RamGb,
                CpuCount = h.CpuCount,
                Criticality = h.Criticality,
                Role = h.Role,
                CategoryId = h.CategoryId,
                VsphereEnvironment = h.VsphereEnvironment,
                Domain = h.Domain,
                Model = h.Model,
                LocalisationId = h.LocalisationId,
                FurnisherId = h.FurnisherId,
                LastBackUp = h.LastBackUp,
                
            }).ToListAsync();
        }
        public async Task<IActionResult> Add(Domain.Host newHost)
        {
           
            _context.Hosts.Add(newHost);
            var response = await _context.SaveChangesAsync();
            if (response > 0)
            {
                return new OkObjectResult(newHost);
            }
            else
            {
                return new BadRequestObjectResult("Failed to add host");
            }
        }

        public async Task<Domain.Host> GetById(int id)
        {
            return await _context.Hosts.FindAsync(id);
        }
        public async Task<IActionResult> Update(Domain.Host host)
        {
            _context.Hosts.Update(host);
            var response = await _context.SaveChangesAsync();
            if (response > 0)
            {
                return new OkObjectResult(host);
            }
            else
            {
                return new BadRequestObjectResult("Failed to update host");
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
