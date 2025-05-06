namespace Documentation_back_end.Domain
{
    public enum IpAddressType
    {
        IPv4,
        IPv6
    }
    public class IpAddress
    {
        public int Id { get; set; }
        public string Ip { get; set; }

        public IpAddressType Type { get; set; }

        public int IpSegmentId { get; set; }
        public IpSegment IpSegment { get; set; }

        public int? VlanId { get; set; } // nullable → Vlan optionnel
        public Vlan Vlan { get; set; }

        public ICollection<Service> Services { get; set; }

    }
}