using System;

namespace NickServer
{
	public class Peer
	{
		public Peer ()
		{
			
		}

		public long Id {
			get;
			set;
		}

		public Uri Address {
			get;
			set;
		}

		public String MAC_AddressHash {
			get;
			set;
		}

	}
}

