using System;

namespace Wozzo.PoshVeyor.Models
{
    public class FullUser : User
    {
        public bool NotifyWhenBuildStatusChangedOnly { get; set; }
        public string SuccessfulDeploymentNotification { get; set; }
        public string FailedDeploymentNotification { get; set; }
    }
}