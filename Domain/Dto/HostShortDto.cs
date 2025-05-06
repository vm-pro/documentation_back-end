namespace Documentation_back_end.Domain.Dto
{
    public class HostShortDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Os { get; set; }
        public string Role { get; set; }
        public bool IsVirtual { get; set; }
        public DateTime? LastBackUp { get; set; } // optionnel
        public string Domain { get; set; }
    }
}
