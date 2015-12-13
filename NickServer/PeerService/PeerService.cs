using System;

namespace NickServer
{
	public class PeerService : IPeerService
	{
		public PeerService ()
		{
		}

		#region IPeerService implementation

		public bool registerPeer (string hash, Uri clientUri)
		{
			PeerManager.registerPeer(hash,clientUri);
		}

		public bool kickoutPeer (string hash, string kickerHash)
		{
			PeerManager.kickoutPeer (hash, kickerHash);
		}

		public System.Collections.Generic.List<Uri> getPeerList ()
		{
			return PeerManager.getPeerList ();
		}

		#endregion
	}
}

