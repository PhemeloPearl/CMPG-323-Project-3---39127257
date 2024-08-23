using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.repositories;
using System.Linq;

namespace TelemetryPortal_MVC.repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }

        // Implement the method as defined in the interface
        public Project GetMostRecentProject()
        {
            return _context.Projects.OrderByDescending(project => project.ProjectCreationDate).FirstOrDefault();
        }

        public Project GetProjectById(Guid id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }
    }
}

