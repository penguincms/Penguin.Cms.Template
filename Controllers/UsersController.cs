using Penguin.Cms.Modules.Security.Services;
using Penguin.Cms.Security.Repositories;
using Penguin.Cms.Web.Security;
using Penguin.Configuration.Abstractions.Interfaces;
using Penguin.Messaging.Core;

namespace Penguin.Cms.Template.Controllers
{
	public class UserController : Penguin.Cms.Modules.Security.Controllers.UserController
	{
		public UserController(IProvideConfigurations configurationService, UserSession userSession, UserRepository userRepository, UserService userService, EmailValidationRepository emailValidationRepository, MessageBus messageBus = null) : base(configurationService, userSession, userRepository, userService, emailValidationRepository, messageBus)
		{
		}
	}
}
