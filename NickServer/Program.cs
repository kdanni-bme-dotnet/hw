using System;

namespace NickServer
{
	class MainClass
	{
		static void Debug ()
		{
			Console.WriteLine ("Debug");
		}

		public static void Main (string[] args)
		{
			if (args == null)
			{
				Usage ();
				System.Environment.Exit(1);
			}
			else
			{
				for (int i = 0; i < args.Length; i++) // Loop through array
				{
					if ("-h".Equals (args[i])) {
						Usage ();
						System.Environment.Exit(0);
					}
					if ("-s".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbConnection.DbPwd = args [i+1];
					}
					if ("-P".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbConnection.DbPort = args [i+1];
					}
					if ("-d".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbConnection.DbDb = args [i+1];
					}
					if ("-u".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbConnection.DbUser = args [i+1];
					}
					if ("-p".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbConnection.DbPwd = args [i+1];
					}
				}
				if (MemoDbConnection.DbPwd == null) {
					Usage ();
					System.Environment.Exit (1);
				}
			}

			Console.WriteLine ("Memo service starting up...");

			try {
				//AnonymousUser.initAnon();

				Debug();
			}
			catch(Exception e)
			{
				System.Console.WriteLine (e.Message);
				System.Console.WriteLine (e.StackTrace);
				System.Console.WriteLine ("Something went wrong.");
				System.Console.WriteLine ("Memo Server Closing...");
				Console.Read ();
				System.Environment.Exit(1);
			}
			System.Console.WriteLine ("Memo Server Closing...");
			Console.Read (); 
		}

		private static void Usage() {
			Console.WriteLine("Usage:");			
			Console.WriteLine("\t-p\tdatabase password (required!)");
			Console.WriteLine("\t-s\tdatabase server");
			Console.WriteLine("\t-P\tdatabase port");
			Console.WriteLine("\t-d\tdatabase");
			Console.WriteLine("\t-u\tdatabase user");
			Console.WriteLine("\t-h\tdisplay this help");
		}
		}
	}
}
