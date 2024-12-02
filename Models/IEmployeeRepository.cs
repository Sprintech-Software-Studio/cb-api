namespace cb.Models
{
	//public interface IEmployeeRepository
	//{
	//	void Add(Employee employee);
	//	List<Employee> Get();
	//}
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
