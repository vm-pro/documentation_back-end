using Microsoft.EntityFrameworkCore;
using Documentation_back_end.Domain;

namespace Documentation_back_end.Data
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Domain.Host> Hosts { get; set; }
        public virtual DbSet<AccessMethod> AccessMethods { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationCategory> ApplicationCategories { get; set; }
        public virtual DbSet<ApplicationHost> ApplicationHosts { get; set; }




}
}
