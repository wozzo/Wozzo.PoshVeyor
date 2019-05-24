using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Wozzo.PoshVeyor.Models;

namespace Wozzo.PoshVeyor.Client
{
    public interface IAppVeyorClient
    {
        [Get("/api/users")]
        Task<IReadOnlyCollection<User>> GetUsers();

        [Get("/api/users/{userId}")]
        Task<User> GetUser(int userId);

        [Get("/api/projects")]
        Task<IReadOnlyCollection<Project>> GetProjects();

        [Get("/api/projects/{accountName}/{projectSlug}")]
        Task<ProjectBuild> GetProjectLastBuild(string accountName, string projectSlug);

        [Get("/api/projects/{accountName}/{projectSlug}/branch/{buildBranch}")]
        Task<ProjectBuild> GetProjectLastBranchBuild(string accountName, string projectSlug, string buildBranch);
        
        [Get("/api/projects/{accountName}/{projectSlug}/build/{buildVersion}")]
        Task<ProjectBuild> GetProjectBuildByVersion(string accountName, string projectSlug, string buildVersion);

        [Get("/api/projects/{accountName}/{projectSlug}/history?recordsNumber={recordsNumber}[&startBuildId={startBuildId}&branch={branch}]")]
        Task<ProjectBuilds> GetProjectHistory(string accountName, string projectSlug, [AliasAs("recordsNumber")] int recordsPerPage, int startBuildId, string branch);
    }
}