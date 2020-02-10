using System;

namespace StoneWare.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int VersionNumberId { get; set; }
        public int OperatingSystemId { get; set; }
        public int StatusId { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeLastUpdated { get; set; }
        public string Problem { get; set; }
        public string Resolution { get; set; }

//        public virtual ProductVersionOs ProductVersionOs { get; set; }
//        public virtual Status Status { get; set; }
    }
}
