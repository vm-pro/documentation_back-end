using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net;

namespace Documentation_back_end.Domain
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ConfigPath { get; set; }
        public string Description { get; set; }

        public int HostId { get; set; }
        public Host Host { get; set; }

        public int IpAddressId { get; set; }
        public IpAddress IpAddress { get; set; }

    }
}
