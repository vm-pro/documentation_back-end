namespace Documentation_back_end.Domain
{
    public class Monitoring
    {
        public int Id { get; set; }
        public string Tool { get; set; }         // Ex: Zabbix, Prometheus
        public string Frequency { get; set; }    // Ex: "5min", "1h"
        public string Details { get; set; }

        public int HostId { get; set; }
        public Host Host { get; set; }
    }
}
