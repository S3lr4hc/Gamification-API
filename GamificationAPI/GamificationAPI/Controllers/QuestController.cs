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
	[RoutePrefix("api/Quest")]
    public class QuestController : ApiController
    {
		private static readonly List<Quest> questList = new List<Quest>()
		{
			new Quest
				{
					QuestId = "1",
					UserId = "1",
					Details = "Glenn Block"
				},
				new Quest
				{
					QuestId = "2",
					UserId = "2",
					Details = "Dan Roth"
				}
		};

		[ResponseType(typeof(List<Quest>))]
		public HttpResponseMessage Get()
		{
			return Request.CreateResponse(HttpStatusCode.OK, questList);
		}

		[HttpPost]
		[ResponseType(typeof(Quest))]
		[Route("login")]
		public HttpResponseMessage Add()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		[HttpPut]
		[ResponseType(typeof(Quest))]
		public HttpResponseMessage Update()
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		[HttpDelete]
		[ResponseType(typeof(Quest))]
		public HttpResponseMessage Delete(string questID)
		{
			return Request.CreateResponse(HttpStatusCode.OK, "");
		}

		//public Quest[] Get()
		//{
		//	return new Quest[]
		//	{
		//		new Quest
		//		{
		//			QuestId = "1",
		//			UserId = "1",
		//			Details = "Glenn Block"
		//		},
		//		new Quest
		//		{
		//			QuestId = "2",
		//			UserId = "2",
		//			Details = "Dan Roth"
		//		}
		//	};
		//}
	}
}
