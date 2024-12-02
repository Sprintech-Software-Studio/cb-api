using System;
using System.Collections.Generic;

namespace cb.Models
{
	public class Store
	{
		public int StoreId { get; private set; }
		public string Name { get; private set; }
		public string Phone { get; private set; }
		public string Email { get; private set; }
		public string Description { get; private set; }
		public string Logo { get; private set; }
		public User Owner { get; private set; }

		public Store(string name, string phone, string email, string description, string logo, User owner)
		{
			Name = name;
			Phone = phone;
			Email = email;
			Description = description;
			Logo = logo;
			Owner = owner;
		}
	}
}
