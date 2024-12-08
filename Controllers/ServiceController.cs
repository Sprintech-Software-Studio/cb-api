using cb.Infrastructure;
using cb.Models;
using Microsoft.AspNetCore.Mvc;

namespace cb.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IServiceRepository _serviceRepository;

		public ServiceController(ServiceRepository serviceRepository)
		{
			_serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));
		}

		[HttpPost]
		public IActionResult Add(string name, string description, string logo, Store store)
		{
			var service = new Service(name, description, logo, store);
			_serviceRepository.Add(service);
			return Ok();
		}

		[HttpPost]
		public IActionResult Index()
		{
			var services = _serviceRepository.Get();
			return Ok(services);
		}

	}
}
