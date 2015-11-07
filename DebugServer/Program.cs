using System;
using V37ZEN.Datagram;
using System.ServiceModel;

namespace DebugServer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");



			using (ServiceHost host = new ServiceHost(typeof(EchoDatagramService)))
			{
				host.Open();

				Console.WriteLine("Datagram Service Host has started up.");
				Console.ReadLine();
			}


			//Console.Read ();
		}
	}
}
