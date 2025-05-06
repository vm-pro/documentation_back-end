namespace Documentation_back_end.Domain
{
    public class ServicePolice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int LocalisationId { get; set; }
        public Localisation Localisation { get; set; }

    }
}
