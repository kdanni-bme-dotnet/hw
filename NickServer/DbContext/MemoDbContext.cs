using System.Data.Entity;
using MySql.Data.Entity;
using System.Data.Common;

namespace NickServer
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class MemoDbContext : DbContext
	{

		public MemoDbContext (DbConnection contextString, bool contextOwnsConnection) 
			: base (contextString, contextOwnsConnection)
		{

		}
	}
}

