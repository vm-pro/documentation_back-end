namespace Documentation_back_end.Domain
{
    public enum ChangeEntityType
    {
        Host,
        Template,
        Document,
        Script,
        User,
        Licence,
        Service,
        Application,
        Vlan
    }
    public class ChangeLog
    {
        public int Id { get; set; }

        public ChangeEntityType EntityType { get; set; }
        public int EntityId { get; set; }

        public string ChangeType { get; set; } // Ex: "Update", "Delete", etc.
        public string ChangeDescription { get; set; }

        public DateTime ChangedAt { get; set; }
        public string ChangedBy { get; set; }
    }
}
