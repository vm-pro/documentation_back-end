namespace Documentation_back_end.Domain
{
    public class ApplicationHost
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public Host Host { get; set; }

        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public DateTime DeploymentDate { get; set; }
        public string Status { get; set; }
    }
}