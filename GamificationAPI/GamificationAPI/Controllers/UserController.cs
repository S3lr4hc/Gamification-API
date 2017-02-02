using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GamificationAPI.Models;
using System.Web.Http.Description;

namespace GamificationAPI.Controllers
{
	[RoutePrefix("api/user")]
    public class UserController : ApiController
    {
		private static readonly List<User> userList = new List<User>
		{
			new User
				{
					UserName = "1",
					UserId = "1",
					Password = "Glenn Block",
					Role = "Admin"
				},
				new User
				{
					UserName = "2",
					UserId = "2",
					Password = "Glenn Block",
					Role = "Lead"
				},
				new User
				{
					UserName = "3",
					UserId = "3",
					Password = "Joe Schmoe",
					Role = "Member"
				}
		};

		[ResponseType(typeof(List<User>))]
		public HttpResponseMessage Get()
		{
			return Request.CreateResponse(HttpStatusCode.OK, userList);
		}

		[HttpPost]
		[ResponseType(typeof(User))]
		[Route("login")]
		public HttpResponseMessage Login()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		[HttpPost]
		[Route("logout")]
		public HttpResponseMessage Logout()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		[HttpPost]
		[Route("register")]
		public HttpResponseMessage Register()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		[HttpPost]
		[Route("role")]
		public HttpResponseMessage Role()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}
		//public User[] Get()
		//{
		//	return new User[]
		//	{
		//		new User
		//		{
		//			UserName = "1",
		//			UserId = "1",
		//			Password = "Glenn Block",
		//			Role = "Admin"
		//		},
		//		new User
		//		{
		//			UserName = "2",
		//			UserId = "2",
		//			Password = "Glenn Block",
		//			Role = "Lead"
		//		},
		//		new User
		//		{
		//			UserName = "3",
		//			UserId = "3",
		//			Password = "Joe Schmoe",
		//			Role = "Member"
		//		}
		//	};
		//}
	}
}
