using cb.Models;

namespace cb.Infrastructure
{
	public class UserRepository : IUserRepository
	{
		private readonly ConnectionContext _context;

		public UserRepository(ConnectionContext context)
		{
			_context = context;
		}
		public void Add(User user)
		{
			_context.Set<User>().Add(user);
			_context.SaveChanges();
		}

		public List<User> Get()
		{
			return _context.Set<User>().ToList();
		}
	}
}
