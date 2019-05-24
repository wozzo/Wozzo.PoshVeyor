using System;
using System.Collections.Generic;

namespace Wozzo.PoshVeyor.Models
{
    public class Build {
            public int BuildId { get; set; }
            public IReadOnlyCollection<Job> Jobs { get; set; }
            public int BuildNumber { get; set; }
            public string Version { get; set; }
            public string Message { get; set; }
            public string Branch { get; set; }
            public string CommitId { get; set; }
            public string AuthorName { get; set; }
            public string AuthorUsername { get; set; }
            public string CommitterName { get; set; }
            public string CommitterUsername { get; set; }
            public DateTime Committed { get; set; }
            public IReadOnlyCollection<string> Messages { get; set; }
            public string Status { get; set; }
            public DateTime Started { get; set; }
            public DateTime Finished { get; set; }
            public DateTime Created { get; set; }
            public DateTime Updated { get; set; }
    }
}