using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Documentation_back_end.Domain
{
    public class Host
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Os { get; set; }
        public int RamGb { get; set; }
        public int CpuCount { get; set; }
        public string Role { get; set; }
        public string Criticality { get; set; }
        public string VsphereEnvironment { get; set; }

        [DefaultValue(false)]
        public bool IsVirtual { get; set; }

        public DateTime? LastBackUp { get; set; } // optionnel

        public string Domain { get; set; }
        public string Model { get; set; }


        public int LocationId { get; set; }
        public Localisation Localisation { get; set; }

        public int FurnisherId { get; set; }
        public Furnisher Furnisher { get; set; }

        public int? CategoryId { get; set; } // nullable
        public Category Category { get; set; }

        public ICollection<Service>? Services { get; set; }

        public ICollection<Script>? Scripts { get; set; }
        public ICollection<ApplicationHost>? ApplicationHosts { get; set; }
        public ICollection<AccessMethod> AccessMethods { get; set; }

    }
}
