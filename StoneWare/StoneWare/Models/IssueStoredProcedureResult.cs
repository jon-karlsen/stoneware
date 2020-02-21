using System;

namespace StoneWare.Models
{
    public class IssueStoredProcedureResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int VersionNumberId { get; set; }
        public string VersionNumber { get; set; }
        public int OperatingSystemId { get; set; }
        public string OperatingSystem { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeLastUpdated { get; set; }
        public string Problem { get; set; }
        public string Resolution { get; set; }
    }
}