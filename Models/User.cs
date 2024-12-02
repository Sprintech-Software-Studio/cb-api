namespace cb.Models
{
	public class User
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Email { get; private set; }
		public string Photo { get; private set; }
		public string Password { get; private set; }
		public Store Store { get; private set; }

		public User(string name, string email, string photo, string password, Store store)
		{
			Name = name;
			Email = email;
			Photo = photo;
			Password = password;
			Store = store;
		}
	}
}
