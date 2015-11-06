using System;
using MySql.Data.MySqlClient;

namespace MemoServer
{
	public class MemoService : IMemoService
	{
		public void putPublicMemo(string message, string sender){
			Memo memo = new Memo(message, sender);

			using (MemoDbConnection conn = new MemoDbConnection())
			{	
				conn.BeginTransaction();
				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
					{
						User Anon = AnonymousUser.getAnon(ctx);
						//ctx.Database.Log = (string log) => { Console.WriteLine(log); };
						ctx.Database.UseTransaction(conn.Transaction);
						ctx.Memos.Add(memo);
						Anon.Memos.Add(memo);
						ctx.SaveChanges();
					}
					conn.CommitTransaction();
				}
				catch
				{
					conn.RollbackTransaction();
					throw;
				}
			}
		}
	}
}

