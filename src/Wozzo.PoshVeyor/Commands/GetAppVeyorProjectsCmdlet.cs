using System.Collections.Generic;
using System.Management.Automation;
using Wozzo.PoshVeyor.Models;

namespace Wozzo.PoshVeyor
{
    [Cmdlet(VerbsCommon.Get, "AppVeyorProjects")]
    [OutputType(typeof(IReadOnlyCollection<User>))]
    public class GetAppVeyorProjectsCmdlet : AppVeyorCmdlet
    {
        protected override void EndProcessing()
        {
            var result = client.GetProjects().Result;
            this.WriteObject(result);
            base.EndProcessing();
        }
    }
}
