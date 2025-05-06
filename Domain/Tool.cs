namespace Documentation_back_end.Domain
{
    public enum ToolCategory
    {
        Monitoring,
        Backup,
        Database,
        Web,
        Other
    }
    public class Tool
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Version { get; set; }
            public ToolCategory Category { get; set; }

            public ICollection<HostTool> HostTools { get; set; }
    }
}
