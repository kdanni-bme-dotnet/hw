using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MemoServer
{
	public class MemoService : IMemoService
	{
		public void putMemo (string message, string to, string from, string hash, Uri clientUri)
		{
			Memo memo = new Memo(message, from);

			using (MemoDbConnection conn = new MemoDbConnection())
			{	
				conn.BeginTransaction();
				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
					{
						ctx.Database.UseTransaction(conn.Transaction);

						var q = from u in ctx.Users where
							u.Username.Equals (to)
							select u;

						if (q.Count() != 1) {
							conn.CommitTransaction();
							return;
						}
						User toUser = q.First();

						ctx.Memos.Add(memo);
						toUser.Memos.Add(memo);
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

		public List<MemoData>  getMyMemos (string nick, string hash, Uri clientUri)
		{
			List<MemoData>  memoData = new List<MemoData> ();
			using (MemoDbConnection conn = new MemoDbConnection())
			{	
				conn.BeginTransaction();
				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
					{
						ctx.Database.UseTransaction(conn.Transaction);

						var q = from u in ctx.Users where
							u.Username.Equals (nick)
							select u;

						if (q.Count() != 1) {
							conn.CommitTransaction();
							return null;
						}
						User toUser = q.First();

						foreach(Memo m in toUser.Memos){
							memoData.Add(
								new MemoData {
									Message = m.Message,
									Sender = m.Sender,
									Timestamp = m.Timestamp
								}
							);
						}
					}
					conn.CommitTransaction();
					return memoData;
				}
				catch
				{
					conn.RollbackTransaction();
					throw;
				}
			}
		}

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


		public void putPublicMemo (string message, string nick, string hash, Uri clientUri)
		{
			this.putPublicMemo (message, nick + "[" + hash + "]@" + clientUri.ToString());
		}
	}
}

