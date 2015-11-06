using System;
using System.ServiceModel;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MemoServer
{
	[ServiceContract]
	public class MemoService
	{
		[OperationContract]
		public void putPublicMemo(string message, string sender){
			Memo memo = new Memo(message, sender);

			using (MemoDbConnection conn = new MemoDbConnection())
			{	
				conn.BeginTransaction();
				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
					{
						//ctx.Database.Log = (string log) => { Console.WriteLine(log); };
						ctx.Database.UseTransaction(conn.Transaction);
						ctx.Memos.Add(memo);
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

