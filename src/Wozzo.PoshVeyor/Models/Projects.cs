using System;
using System.Collections.Generic;

namespace Wozzo.PoshVeyor.Models
{
    public class Project
    {
      public int ProjectId { get; set; }
      public int AccountId { get; set; }
      public string AccountName { get; set; }
      public IReadOnlyCollection<Build> Builds { get; set; }
      public string Name { get; set; }
      public string Slug { get; set; }
      public string RepositoryType { get; set; }
      public string RepositoryScm { get; set; }
      public string RepositoryName { get; set; }
      public string RepositoryBranch { get; set; }
      public bool IsPrivate { get; set; }
      public bool SkipBranchesWithoutAppveyorYml { get; set; }
      public NuGetFeed NuGetFeed { get; set; }
      public DateTime Created { get; set; }
   }
}