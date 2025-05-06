
using Documentation_back_end.Data.Interfaces;
using Documentation_back_end.Domain.Dto;
using Documentation_back_end.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Documentation_back_end.Service
{
    public class HostService: IHostService
    {
        private readonly IHostRepo _hostRepository;
        public HostService(IHostRepo hostReposirory) {
            _hostRepository = hostReposirory;
        }
        public async Task<IEnumerable<Domain.Host>> GetAll()
        {
            return await _hostRepository.GetAll();
        }
        public async Task<IEnumerable<HostShortDto>> GetAllForGrid()
        {
            return await _hostRepository.GetAllForGrid();
        }
        public async Task<IActionResult> Add(HostAdding host)
        {
            var newHost = new Domain.Host
            {
                Name = host.Name,
                IsVirtual = host.IsVirtual,
                Os = host.Os,
                RamGb = host.RamGb,
                CpuCount = host.CpuCount,
                Criticality = host.Criticality,
                Role = host.Role,
                CategoryId = host.CategoryId,
                VsphereEnvironment = host.VsphereEnvironment,
                Domain = host.Domain,
                Model = host.Model,
                LocalisationId = host.LocalisationId,
                FurnisherId = host.FurnisherId,

            };
            return await _hostRepository.Add(newHost);
        }
        public async Task<IActionResult> Delete(int id)
        {
            return await _hostRepository.Delete(id);
        }
    }
}
