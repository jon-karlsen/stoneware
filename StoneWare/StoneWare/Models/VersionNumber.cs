using System;
using System.Collections.Generic;

namespace StoneWare.Models
{
    public class VersionNumber
    {
        public VersionNumber()
        {
            ProductVersionOs = new HashSet<ProductVersionOs>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductVersionOs> ProductVersionOs { get; set; }
    }
}
