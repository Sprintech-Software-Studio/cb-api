using cb.Infrastructure;
using cb.Models;
using Microsoft.AspNetCore.Mvc;

namespace cb.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : Controller
	{
		private readonly IUserRepository _userRepository;

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
		}

		[HttpPost]
		public IActionResult Add(string name, string email, string photo, string password, Store store)
		{
			var validationErrors = new List<string>();

			if (string.IsNullOrWhiteSpace(name))
				validationErrors.Add("O nome é obrigatório.");

			if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
				validationErrors.Add("E-mail inválido.");

			if (string.IsNullOrWhiteSpace(password) || password.Length <= 5)
				validationErrors.Add("A senha deve conter pelo menos 6 caracteres.");

			if (validationErrors.Any())
				return BadRequest(new { Errors = validationErrors });


			var user = new User(name, email, photo, password, store);

			try
			{
				_userRepository.Add(user);
				return Ok("Usuário adicionado com sucesso!");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Erro ao adicionar o usuário: {ex.Message}");
			}
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(" Pegou");
		}
	}
}
