using System;
using System.Linq;
using MySql.Data.MySqlClient;
using MemoServer;

namespace NickServer
{
	public class NickService : INickService
	{
		private static readonly TimeSpan timeout = new TimeSpan(1,0,0);

		public bool registerNick (string nick, string hash, Uri clientUri)
		{

			using (MemoDbConnection conn = new MemoDbConnection())
			{	
				conn.BeginTransaction();
				try { 
					using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
					{	
						var qu = from u in ctx.Users where
							u.Username.Equals (nick)
							select u;

						if (qu.Count() > 0) {
							foreach(User u in qu){
								if(u.LastOnline.Add(timeout).CompareTo(DateTime.UtcNow) > 0){
									conn.CommitTransaction();
									return false;
								} else {
									ctx.Users.Remove(u);
								}
							}
						}

						User nu = new User {
							LastOnline = DateTime.UtcNow,
							Username = nick,
							Password = hash
						};

						ctx.Users.Add(nu);
						ctx.SaveChanges();

					}
					conn.CommitTransaction();
					return true;
				}
				catch
				{
					conn.RollbackTransaction();
					return false;
				}
			}
		}

	}
}

