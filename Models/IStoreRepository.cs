namespace cb.Models
{
	public interface IStoreRepository
	{
		void Add(Store store);

		List<Store> Get();
	}
}
 