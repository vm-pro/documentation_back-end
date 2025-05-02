namespace Documentation_back_end.Domain
{
    public class IpSegment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cidr { get; set; }

        public ICollection<Vlan> Vlans { get; set; }
        public ICollection<IpAddress> IpAddresses { get; set; }

    }
}