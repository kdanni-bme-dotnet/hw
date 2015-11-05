using System;
using System.Collections.Generic;

namespace MemoServer
{
	public class User
	{
		public string username {
			get;
			set;
		}

		public string Password {
			get;
			set;
		}

		public DateTime LastOnline {
			get;
			set;
		}

		public List<Memo> Memos {
			get;
			set;
		}

		public User ()
		{
		}
	}
}

