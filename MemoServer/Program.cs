using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MemoServer
{
	class MainClass
	{
		private static void Debug() {
			using (DbConnection conn = MemoDbContext.getDbConnection())
			{
				// Create database if not exists
				using (MemoDbContext contextDB = new MemoDbContext(conn, false))
				{
					contextDB.Database.CreateIfNotExists();
				}

				conn.Open();
				MySqlTransaction transaction = (MySqlTransaction)conn.BeginTransaction();

				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn, false))
					{
						ctx.Database.Log = (string message) => { Console.WriteLine(message); };
						ctx.Database.UseTransaction(transaction);

						Memo testMemo = new Memo("Hello", "d");

						ctx.Memos.Add(testMemo);

						ctx.SaveChanges();
					}

					transaction.Commit();
				}
				catch
				{
					transaction.Rollback();
					throw;
				}
			}
		}

		public static void Main (string[] args)
		{
			if (args == null)
			{
				Usage ();
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
						MemoDbContext.DbPwd = args [i+1];
					}
					if ("-p".Equals (args[i])) {
						if(args.Length <= i+1 || args [i+1] == null){
							continue;
						}
						MemoDbContext.DbPwd = args [i+1];
					}
				}
				if (MemoDbContext.DbPwd == null) {
					Usage ();
					System.Environment.Exit (1);
				}
			}

			Console.WriteLine ("Memo service starting up...");

			try {
				Debug();
			}
			catch 
			{
				System.Console.WriteLine ("Something went wrong.");
				System.Console.WriteLine ("Memo Server Closing...");
				System.Environment.Exit(1);
			}
			System.Console.WriteLine ("Memo Server Closing...");
		}
		
		private static void Usage() {
			Console.WriteLine("Usage:");			
			Console.WriteLine("\t-p\tdatabase password (required!)");
			Console.WriteLine("\t-s\tdatabase server");
			Console.WriteLine("\t-h\tthis help");
		}
	}
}
