using cb.Models;

namespace cb.Infrastructure
{
	public class StoreRepository : IStoreRepository
	{
		private readonly ConnectionContext _context;

		public StoreRepository(ConnectionContext context)
		{
			_context = context;
		}

		public void Add(Store store)
		{
			_context.Set<Store>().Add(store);
			_context.SaveChanges();
		}

		public List<Store> Get()
		{
			return _context.Set<Store>().ToList();
		}
	}
}
