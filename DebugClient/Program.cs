using System;
using V37ZEN.Datagram;
using System.Diagnostics;

namespace DebugClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Datagram d = new Datagram ();
			d.Timestamp = DateTime.UtcNow;
			d.Message = "Echo echo!";
			d.Metadata = "HW!";

			try {

				using(DatagramServiceClient client = new DatagramServiceClient("DatagramClientUdpEndpoint")){

					client.ProcessDatagram(d);
				}

			} catch (Exception ex) {
				Debugger.Log (0, Debugger.DefaultCategory, ex.Message + '\n' + ex.StackTrace.ToString ());
			}
		}
	}
}
