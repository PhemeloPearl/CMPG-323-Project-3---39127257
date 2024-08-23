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
            return _context.Clients
                .OrderByDescending(c => c.DateOnboarded)
                .FirstOrDefault();
        }

        // Additional methods specific to ClientRepository
        public Client GetClientById(Guid id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
        }
    }
}
