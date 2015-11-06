using System.Data.Entity;
using MySql.Data.Entity;
using System.Data.Common;

namespace MemoServer
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MemoDbContext : DbContext
	{
		public DbSet<Memo> Memos{ get; set; }

		public DbSet<User> Users{ get; set; }

		public MemoDbContext (DbConnection contextString, bool contextOwnsConnection) 
			: base (contextString, contextOwnsConnection)
		{

		}
	}
}

