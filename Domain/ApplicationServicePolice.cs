namespace Documentation_back_end.Domain
{
    public class ApplicationServicePolice
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public int ServicePoliceId { get; set; }
        public ServicePolice ServicePolice { get; set; }
    }
}
