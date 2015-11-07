using System.ServiceModel;
using System.Runtime.Serialization;
using System;
using System.Diagnostics;

namespace V37ZEN.Datagram
{

	#region contract
	[ServiceContract]
	public interface IDatagramService
	{
		[OperationContract (IsOneWay = true)]
		void ProcessDatagram (Datagram datagram);
	}

	[DataContract]
	public class Datagram
	{
		public Datagram (string message)
		{
			this.Message = message;
			this.Timestamp = DateTime.UtcNow;
		}

		public Datagram (string message, string metadata)
		{
			this.Message = message;
			this.Metadata = metadata;
			this.Timestamp = DateTime.UtcNow;
		}

		[DataMember]
		public string Metadata { get; set; }

		[DataMember (IsRequired = true)]
		public string Message { get; set;}

		[DataMember]
		public DateTime Timestamp { get; set;}

		public override string ToString ()
		{
			return string.Format ("[Datagram: Metadata={0}, Message={1}, Timestamp={2}]", Metadata, Message, Timestamp);
		}
	}

	#endregion

	#region EchoDatagramService

	public class EchoDatagramService : IDatagramService
	{
		public void ProcessDatagram (Datagram datagram)
		{
			var text = "Process Datagram: " + datagram.ToString ();
			Debugger.Log(3,Debugger.DefaultCategory,text);
			Console.WriteLine (text);
		}
	}

	#endregion

}