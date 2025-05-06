namespace Documentation_back_end.Domain
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LicenceId { get; set; }
        public Licence Licence { get; set; }
        public int ApplicationCategoryId { get; set; }
        public ApplicationCategory ApplicationCategory { get; set; }
        public ICollection<ApplicationHost> ApplicationHosts { get; set; }


    }
}
