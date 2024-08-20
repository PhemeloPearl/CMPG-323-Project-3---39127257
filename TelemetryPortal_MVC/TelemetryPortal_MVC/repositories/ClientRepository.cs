using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.repositories
{
    public class ClientRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }
    }
}
