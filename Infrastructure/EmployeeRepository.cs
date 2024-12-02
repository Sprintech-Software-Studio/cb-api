using cb.Models;
using System.Collections.Generic;

namespace cb.Infrastructure
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly ConnectionContext _context;

		public EmployeeRepository(ConnectionContext context)
		{
			_context = context;
		}

		public Employee GetEmployeeById(int id)
		{
			return _context.Set<Employee>().Find(id);
		}

		public IEnumerable<Employee> GetAllEmployees()
		{
			return _context.Set<Employee>();
		}

		public void AddEmployee(Employee employee)
		{
			_context.Set<Employee>().Add(employee);
			_context.SaveChanges();
		}

		public void UpdateEmployee(Employee employee)
		{
			_context.Set<Employee>().Update(employee);
			_context.SaveChanges();
		}

		public void DeleteEmployee(int id)
		{
			var employee = _context.Set<Employee>().Find(id);
			if (employee != null)
			{
				_context.Set<Employee>().Remove(employee);
				_context.SaveChanges();
			}
		}
	}
}