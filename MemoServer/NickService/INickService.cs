using System;
using System.ServiceModel;

namespace NickServer
{
	[ServiceContract]
	public interface INickService
	{
		[OperationContract]
		void registerNick (string nick, string hash, Uri clientUri);


	}
}

