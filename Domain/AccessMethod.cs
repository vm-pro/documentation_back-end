namespace Documentation_back_end.Domain
{
    public enum AccessMethodType
    {
        SSH,
        Telnet,
        RDP,
        HTTP,
        HTTPS,
        SNMP,
        FTP,
        SFTP,
        SCP,
        WinRM,
        VSpehere,
        WebUI, 
        VNC
    }
    public class AccessMethod
    {
        public int Id {  get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int HostId { get; set; }
        public Host Host { get; set; }

        public AccessMethodType Type { get; set; }
        public int Port { get; set; }

    }
}
