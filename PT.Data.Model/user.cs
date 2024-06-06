using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT.Data.Model
{
	public class user
	{
		public int id { get; set; }

		public string username { get; set; }
		public string password { get; set; }
		public int status { get; set; }
		public DateTime createdOn { get; set; }
		public DateTime modifiedOn { get; set; }
	}
}
