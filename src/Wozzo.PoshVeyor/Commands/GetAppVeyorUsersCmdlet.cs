using System.Collections.Generic;
using System.Management.Automation;
using Wozzo.PoshVeyor.Models;

namespace Wozzo.PoshVeyor
{
    [Cmdlet(VerbsCommon.Get, "AppVeyorUsers")]
    [OutputType(typeof(IReadOnlyCollection<User>))]
    public class GetAppVeyorUsersCmdlet : AppVeyorCmdlet
    {
        protected override void EndProcessing()
        {
            var users = client.GetUsers().Result;
            this.WriteObject(users);
            base.EndProcessing();
        }
    }
}
