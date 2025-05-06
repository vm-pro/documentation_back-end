
using Documentation_back_end.Data.Interfaces;
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
        public async Task<IActionResult> Add(string name)
        {
            return await _hostRepository.Add(name);
        }
        public async Task<IActionResult> Delete(int id)
        {
            return await _hostRepository.Delete(id);
        }
    }
}
