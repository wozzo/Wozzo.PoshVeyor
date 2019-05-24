using System.Management.Automation;
using Wozzo.PoshVeyor.Client;

namespace Wozzo.PoshVeyor
{
    public abstract class AppVeyorCmdlet : PSCmdlet
    {
        [Parameter]
        public string Token { get; set; }

        protected IAppVeyorClient client => AppVeyorClientFactory.Create(Token);
    }
}
