using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Penguin.Authentication.Abstractions.Interfaces;
using Penguin.Authentication.Domain;

namespace Penguin.Cms.Template
{
	public class Startup : Penguin.Cms.Web.Mvc.Startup
	{
		public Startup(IConfiguration configuration) : base(configuration)
		{
		}

		public override void ConfigureAdditionalServices(IServiceCollection services)
		{
			services.AddSingleton<IAuthenticator, DomainAuthenticator>();
		}
	}
}
