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
        public int Id { get; set; }
        public AccessMethodType Type { get; set; }
        public int port { get; set; } // Port number for the access method

        public int HostId { get; set; } // Foreign key to the Host table
        public ICollection<Host> Hosts { get; set; } // Navigation property to the Host entity
        public int UserId { get; set; } // Foreign key to the User table
        public ICollection<User> Users { get; set; }

    }
}
