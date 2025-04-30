namespace Documentation_back_end.Service.Interfaces
{
    public interface IHostService
    {
        Task<IEnumerable<Domain.Host>> GetAll();
    }
}
