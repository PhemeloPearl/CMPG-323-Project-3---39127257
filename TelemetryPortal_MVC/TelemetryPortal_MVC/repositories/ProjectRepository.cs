using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;

namespace TelemetryPortal_MVC.repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context): base(context) 
        {

        }
        public Project GetMostRecentServices()
        {
            return _context.Projects.OrderByDescending(project => project.CreatedDate).FirstOrDefault();
        }
    }
}
