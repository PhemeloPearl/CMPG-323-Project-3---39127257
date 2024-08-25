using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(TechtrendsContext context) : base(context)
        {
        }

        public Client GetMostRecentClient()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Clients
                .OrderByDescending(c => c.DateOnboarded)
                .FirstOrDefault();
#pragma warning restore CS8603 // Possible null reference return.
        }

        // Additional methods specific to ClientRepository
        public Client GetClientById(Guid id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
