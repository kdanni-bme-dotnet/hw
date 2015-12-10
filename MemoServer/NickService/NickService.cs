using System;
using MySql.Data.MySqlClient;

namespace NickServer
{
	public class NickService : INickService
	{
		#region INickService implementation

		public void registerNick (string nick, string hash, Uri clientUri)
		{
			throw new NotImplementedException ();
		}

		#endregion

	}
}

