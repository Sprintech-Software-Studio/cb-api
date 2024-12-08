using cb.Models;

namespace cb.Infrastructure
{
	public class ServiceRepository : IServiceRepository
	{
		private readonly ConnectionContext _context;

		public ServiceRepository(ConnectionContext context)
		{
			_context = context;
		}

		public void Add(Service service)
		{
			_context.Set<Service>().Add(service);
			_context.SaveChanges();
		}

		public List<Service> Get()
		{
			return _context.Set<Service>().ToList();
		}
	}
}
