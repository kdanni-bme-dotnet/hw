using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MemoServer
{
	[ServiceContract]
	public interface IMemoService
	{
		[OperationContract]
		void putPublicMemo (string message, string sender, string hash, Uri clientUri);

		[OperationContract]
		void putMemo (string message, string to, string from, string hash, Uri clientUri);

		[OperationContract]
		List<MemoData> getMyMemos (string nick, string hash, Uri clientUri);

	}

	[DataContract]
	public class MemoData {

		[DataMember]
		public string Sender { get; set;}

		[DataMember]
		public string Message { get; set;}

		[DataMember]
		public DateTime Timestamp { get; set;}

	}
}

