namespace cb.Models
{
	public interface IUserRepository
	{
		void Add(User user);
		List<User> Get();
	}
}
