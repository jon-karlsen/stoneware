using System;
using System.Collections.Generic;

namespace StoneWare.Models
{
    public class ProductVersionOs
    {
        public ProductVersionOs()
        {
            Issue = new HashSet<Issue>();
        }

        public int ProductId { get; set; }
        public int OperatingSystemId { get; set; }
        public int VersionNumberId { get; set; }

        public virtual OperatingSystem OperatingSystem { get; set; }
        public virtual Product Product { get; set; }
        public virtual VersionNumber VersionNumber { get; set; }
        public virtual ICollection<Issue> Issue { get; set; }
    }
}
