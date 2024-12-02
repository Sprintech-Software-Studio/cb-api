namespace cb.Models
{
	public interface IServicesRepository
	{
		void Add(Service service);
		List<Service> Get();
	}
}
