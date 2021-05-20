
using Microsoft.AspNetCore.Mvc;

namespace netcore_appengine_deploy.Controllers
{
	/// <summary>
	/// API Controller
	/// </summary>
	[Produces("application/json")]
	[Route("[controller]")]

	public class MainController : Controller
	{
		/// <summary>
		/// teste
		/// </summary>
		[Route("test")]
		[HttpGet]
		public ActionResult Get()
		{
			return StatusCode(200, "Teste ok ;-)");
		}
	}
}
