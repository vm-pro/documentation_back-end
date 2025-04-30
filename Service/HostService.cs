
using Documentation_back_end.Data.Interfaces;
using Documentation_back_end.Service.Interfaces;

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
    }
}
