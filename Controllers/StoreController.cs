using Microsoft.AspNetCore.Mvc;
using cb.Models;

namespace cb.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class StoreController : ControllerBase
	{
		private readonly IStoreRepository _storeRepository;

		public StoreController(IStoreRepository storeRepository)
		{
			_storeRepository = storeRepository ?? throw new ArgumentNullException(nameof(storeRepository));
		}

		[HttpPost]
		public IActionResult Add(string name, string phone, string email, string description, string logo, User owner)
		{
			var store = new Store(name, phone, email, description, logo, owner);
			_storeRepository.Add(store);
			return Ok();
		}

		[HttpGet]
		public IActionResult Get()
		{
			var stores = _storeRepository.Get();
			return Ok(stores);
		}
	}
}
