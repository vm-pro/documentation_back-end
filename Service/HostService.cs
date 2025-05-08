
using Documentation_back_end.Controllers;
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
        public async Task<IEnumerable<HostDto>> GetAllForGrid()
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

        public async Task<IActionResult> Update(int id, HostUpd host)
        {
            var existingHost = await _hostRepository.GetById(host.id);
            if (existingHost == null)
            {
                return new NotFoundResult();
            }
            existingHost.Name = host.Name;
            existingHost.IsVirtual = host.IsVirtual;
            existingHost.Os = host.Os;
            existingHost.RamGb = host.RamGb;
            existingHost.CpuCount = host.CpuCount;
            existingHost.Criticality = host.Criticality;
            existingHost.Role = host.Role;
            existingHost.CategoryId = host.CategoryId;
            existingHost.VsphereEnvironment = host.VsphereEnvironment;
            existingHost.Domain = host.Domain;
            existingHost.Model = host.Model;
            existingHost.LocalisationId = host.LocalisationId;
            existingHost.FurnisherId = host.FurnisherId;
            return await _hostRepository.Update(existingHost);
        }


        public async Task<IActionResult> Delete(int id)
        {
            return await _hostRepository.Delete(id);
        }
    }
}
