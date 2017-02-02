using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamificationAPI.Models
{
	/// <summary>
	/// Quest
	/// </summary>
	public class Quest
	{

		public string UserId { get; set; }
		public string QuestId { get; set; }
		public string Details { get; set; }
	}
}