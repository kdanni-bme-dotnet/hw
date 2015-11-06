using System;
using MySql.Data.MySqlClient;

namespace MemoServer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string server = "192.168.92.1";
			string connectionString = ConnectionString (server);

			Console.WriteLine ("Memo service starting up...");

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				// Create database if not exists
				using (MemoDbContext contextDB = new MemoDbContext(conn, false))
				{
					contextDB.Database.CreateIfNotExists();
				}

				conn.Open();
				MySqlTransaction transaction = conn.BeginTransaction();

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
			System.Console.WriteLine ("Memo Server Closing...");
		}


		
		static string ConnectionString(string server)
		{
			string pwd = "password" ;
			Console.Write("PWD: ");
			pwd = Console.ReadLine();


			var connectionString = "server="+ server +";port=3306;database=dotnet2;uid=dotNet;password="+pwd+ ";Persist Security Info=True;";
			return connectionString;
		}
	}
}
