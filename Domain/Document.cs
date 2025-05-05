using Microsoft.AspNetCore.Routing.Template;

namespace Documentation_back_end.Domain
{
    public enum FileType
    {
        pdf, 
        xlsx,
        doc,
        docx
    }
    public enum Status
    {
        up_to_date, 
        to_update, 
        outdated
    }
    public class Document
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public string url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public Status Status { get; set; }
        public int TemplateId { get; set; }
        public Template Template { get; set; }
        public int HostId { get; set; }
        public Host Host { get; set; }

    }
}
