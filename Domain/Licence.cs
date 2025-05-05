namespace Documentation_back_end.Domain
{
    public class Licence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Beginning {  get; set; }
        public DateTime Ending { get; set; }

    }
}