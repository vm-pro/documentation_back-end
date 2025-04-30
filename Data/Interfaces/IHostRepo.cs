namespace Documentation_back_end.Data.Interfaces
{
    public interface IHostRepo
    {
        Task<IEnumerable<Domain.Host>> GetAll();
    }
}
