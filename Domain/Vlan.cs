namespace Documentation_back_end.Domain
{
    public class Vlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VlanId { get; set; }
        public string Description { get; set; }

        public int IpSegmentId { get; set; }
        public IpSegment IpSegment { get; set; }

        public ICollection<IpAddress> IpAddresses { get; set; }

    }
}