namespace Documentation_back_end.Domain.Dto
{
    public class HostAdding
    {
        public string Name { get; set; }
        public bool IsVirtual { get; set; }
        public string Os { get; set; }
        public int RamGb { get; set; }
        public int CpuCount { get; set; }
        public string Criticality { get; set; }
        public string Role { get; set; }
        public int? CategoryId { get; set; } // nullable
        public string VsphereEnvironment { get; set; }
        public string Domain { get; set; }
        public string Model { get; set; }
        public int? LocalisationId { get; set; }
        public int? FurnisherId { get; set; }
    }
}
