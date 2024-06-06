using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT.Data.Model
{
	public class userProfile
	{
		public int id { get; set; }
		//public user user { get; set; }
		public int userid { get; set; }
		public string email { get; set; }
		public string mobilephone { get; set; }
		public bool isEmailVerified { get; set; } = false;
		public bool isMobilephoneVerified { get; set; } = false;
		public DateTime emailVerifiedOn { get; set; } 
		public DateTime mobilePhoneVerifiedOn { get; set; }
		public DateTime createdOn { get; set; } = DateTime.UtcNow;
		public DateTime modifiedOn { get; set; } = DateTime.UtcNow;
	}
}
