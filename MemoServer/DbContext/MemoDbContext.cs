using System;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Common;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MemoServer
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MemoDbContext : DbContext
	{
		private static DbConnection DbConnection;
		public static string DbPwd { get; set; }
		public static string DbServer { get; set; }

		public static DbConnection getDbConnection(){
			if (DbConnection != null) {
				return DbConnection;
			}
			if (DbServer == null) {
				DbServer = ConfigurationManager.AppSettings ["db.server"];
			}
			string connectionString = "server="+ DbServer 
				+";port=3306;database=dotnet2;uid=dotNet;password="+ DbPwd
					+ ";Persist Security Info=True;";

			DbConnection = new MySqlConnection (connectionString);
			return DbConnection;
		}

		public DbSet<Memo> Memos{ get; set; }

		public DbSet<User> Users{ get; set; }

		public MemoDbContext (DbConnection contextString, bool contextOwnsConnection) : base (contextString, contextOwnsConnection)
		{

		}
	}
}

