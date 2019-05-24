using System.Collections.Generic;

namespace Wozzo.PoshVeyor.Models
{
    public class ProjectBuilds {
        public Project Project { get; set; }
        public IReadOnlyCollection<Build> Builds { get; set; }
    }
}