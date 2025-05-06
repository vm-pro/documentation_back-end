namespace Documentation_back_end.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Host> Hosts { get; set; }
    }
}