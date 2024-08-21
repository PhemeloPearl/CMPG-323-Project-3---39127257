using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetMostRecentClient();
    }
}
