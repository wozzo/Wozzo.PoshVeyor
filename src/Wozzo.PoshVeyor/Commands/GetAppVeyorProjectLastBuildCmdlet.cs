using System.Collections.Generic;
using System.Management.Automation;
using Wozzo.PoshVeyor.Models;

namespace Wozzo.PoshVeyor
{
    [Cmdlet(VerbsCommon.Get, "AppVeyorProjects")]
    [OutputType(typeof(IReadOnlyCollection<User>))]
    public class GetAppVeyorProjectLastBuildCmdlet : AppVeyorCmdlet
    {
        [Parameter(Position = 0)]
        public string AccountName { get; set; }

        [Parameter(Position = 1)]
        public string ProjectSlug { get; set; }
        protected override void EndProcessing()
        {
            var result = client.GetProjectLastBuild(AccountName, ProjectSlug).Result;
            this.WriteObject(result);
            base.EndProcessing();
        }
    }
}
