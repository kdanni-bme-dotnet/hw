using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoServer
{
	public class AnonymousUser
	{
		public static readonly string ANON_NAME = "Anonymous"; 

		public static void initAnon(){
			using (MemoDbConnection conn = new MemoDbConnection()) {	
				using (MemoDbContext ctx = new MemoDbContext(conn.Connection, false))
				{
					//var q = from u in ctx.Users where
					//        u.Username.Equals (ANON_NAME)
					//		select u;

					var q = from u in ctx.Users	select u;

					System.Console.WriteLine (q == null);
					if (q.Count() < 1) {
						var anon = new User ();
						anon.Username = ANON_NAME;
						anon.LastOnline = DateTime.Now;
						anon.Password = "PWD";

						conn.BeginTransaction ();
						try {
							ctx.Database.UseTransaction (conn.Transaction);
							ctx.Users.Add (anon);
							ctx.SaveChanges ();

							conn.CommitTransaction ();
						} catch {
							conn.RollbackTransaction ();
						}
					}
				}	 
			}
		}
		public static User getAnon(MemoDbContext ctx){
			bool loop = true;
			int threshold = 3;
			while (loop) {
				var q = from u in ctx.Users where
					u.Username.Equals (ANON_NAME)
						select u;

				if (q.Count () < 1) {
					initAnon ();
					threshold--;
				} else {
					return q.First ();
				}
				if (threshold < 1) {
					break;
				}
			}
			return null;
		}
	}
}

