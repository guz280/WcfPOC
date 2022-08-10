using AgentData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WcfPoc.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AgentServiceController : ControllerBase
	{

		private readonly ILogger<AgentServiceController> _logger;

		public AgentServiceController(ILogger<AgentServiceController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public async Task<bool> Get()
		{
			AgentServiceClient agentServiceClient = new AgentServiceClient();
			GetAllRequest getAllRequest = new GetAllRequest();
			var result = await agentServiceClient.GetAllAsync(getAllRequest);
			return true;
		}

		/*
		 For more INFO follow: https://www.thecodebuzz.com/consuming-wcf-web-services-in-net-core-best-practices/
		 */
	}
}
