using System;

namespace Wozzo.PoshVeyor.Models
{
    public class User
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public bool IsOwner { get; set; }
        public bool IsCollaborator { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string SuccessfulBuildNotification { get; set; }
        public string FailedBuildNotification { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}