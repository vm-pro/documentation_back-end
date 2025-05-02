namespace Documentation_back_end.Domain
{
    public enum LocalisationType
    {
        Floor,
        Room,
        Cupboard
    }
    public class Localisation
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public Localisation Parent { get; set; }
        public ICollection<Localisation> Children { get; set; }

        public LocalisationType Type { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Host> Hosts { get; set; }
    }
}