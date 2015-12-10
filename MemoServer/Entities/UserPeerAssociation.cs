using System;

namespace MemoServer
{
	public class UserPeerAssociation
	{
		public UserPeerAssociation ()
		{
		}

		public long Id {
			get;
			set;
		}

		public Status Status {
			get;
			set;
		}
			
		public User User {
			get;
			set;
		}

		public Peer Peer {
			get;
			set;
		}
	}
}

