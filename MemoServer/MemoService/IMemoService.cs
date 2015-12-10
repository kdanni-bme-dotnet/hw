using System;
using System.ServiceModel;

namespace MemoServer
{
	[ServiceContract]
	public interface IMemoService
	{
		[OperationContract]
		void putPublicMemo (string message, string nick, string hash, Uri clientUri);


	}
}

