using System.Collections.Generic;

namespace StoneWare.Models
{
    public class Status
    {
        public Status()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Issue> Issue { get; set; }
    }
}
