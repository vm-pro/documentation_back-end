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
        public virtual DbSet<ApplicationServicePolice> ApplicationServicesPolice { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ChangeLog> ChangeLog { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Furnisher> Furnishers { get; set; }
        public virtual DbSet<HostTool> HostTools { get; set; }
        public virtual DbSet<IpAddress> IpAddresses { get; set; }
        public virtual DbSet<IpSegment> IpSegments { get; set; }
        public virtual DbSet<Licence> Licences { get; set; }
        public virtual DbSet<Localisation> Localisations { get; set; }
        public virtual DbSet<Monitoring> Monitoring { get; set; }
        public virtual DbSet<Script> Scripts { get; set; }
        public virtual DbSet<Domain.Service> Services { get; set; }
        public virtual DbSet<ServicePolice> ServicesPolice { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Tool> Tool { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vlan> Vlans { get; set; }





    }
}
