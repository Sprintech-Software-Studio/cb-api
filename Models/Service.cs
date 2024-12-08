using System.Numerics;

namespace cb.Models
{
	public class Service
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Description { get; private set; }
		public decimal Price { get; private set; }
		public string Photo { get; private set; }
		public Store Store { get; private set; }
		public Employee Employee { get; private set; }

		public Service(string name, string description, decimal price, string photo, Store store, Employee employee)
		{
			Name = name;
			Description = description;
			Price = price;
			Photo = photo;
			Store = store;
			Employee = employee;
		}
	}
}