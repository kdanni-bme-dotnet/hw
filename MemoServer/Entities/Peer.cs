using System;

namespace MemoServer
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

