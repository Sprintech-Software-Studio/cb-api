namespace cb.Models
{
	public interface IServiceRepository
	{
		void Add(Service service);
		List<Service> Get();
	}
}
