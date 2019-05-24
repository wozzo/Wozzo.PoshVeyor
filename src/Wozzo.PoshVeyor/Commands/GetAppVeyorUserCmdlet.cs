using System.Collections.Generic;
using System.Management.Automation;
using Wozzo.PoshVeyor.Models;

namespace Wozzo.PoshVeyor
{
    [Cmdlet(VerbsCommon.Get, "AppVeyorUser")]
    [OutputType(typeof(IReadOnlyCollection<User>))]
    public class GetAppVeyorUserCmdlet : AppVeyorCmdlet
    {
        [Parameter(Position = 1)]
        public int UserId { get; set; }

        protected override void EndProcessing()
        {
            var users = client.GetUser(UserId).Result;
            this.WriteObject(users);
            base.EndProcessing();
        }
    }
}
