namespace Documentation_back_end.Domain
{
    public class Script
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; } // Path to the script file
        public string Description { get; set; }
        public DateTime? Schedule { get; set; } // Date and time when the script is scheduled to run


        // Foreign key
        public int? UserId { get; set; }
        public int? HostId { get; set; } // Foreign key to the Host table
        // Navigation property
        public User? User { get; set; }
        public Host? Hosts { get; set; }
    }
}