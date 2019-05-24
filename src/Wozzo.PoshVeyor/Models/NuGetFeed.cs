using System;

namespace Wozzo.PoshVeyor.Models
{
    public class NuGetFeed {
       public string Id { get; set; }
       public string Name { get; set; }
       public bool PublishingEnabled { get; set; }
       public DateTime Created { get; set; }
   }
}