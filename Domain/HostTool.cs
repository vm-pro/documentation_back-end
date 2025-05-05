namespace Documentation_back_end.Domain
{
    public enum ToolStatus
    {
        Running,
        Stopped,
        Disabled
    }
    public class HostTool
    {

        public int Id { get; set; }

        public string ConfigPath { get; set; }

        public int HostId { get; set; }
        public Host Host { get; set; }

        public int ToolId { get; set; }
        public Tool Tool { get; set; }

        public ToolStatus Status { get; set; }


    }
}