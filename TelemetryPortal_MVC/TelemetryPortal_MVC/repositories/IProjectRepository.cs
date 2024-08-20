using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Project GetMostRecentProject();
    }
}
