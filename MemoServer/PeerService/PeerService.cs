using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoServer
{
	public class PeerService : IPeerService
	{

		public bool registerPeer (string hash, Uri clientUri)
		{
			using (MemoDbConnection conn = new MemoDbConnection ()) {	
				conn.BeginTransaction ();
				try { 
					using (MemoDbContext ctx = new MemoDbContext (conn.Connection, false)) {	
						var qp = from p in ctx.Peers
						         where
							p.MAC_AddressHash.Equals (hash)
						         select p;

						if (qp.Count () > 1) {
							conn.CommitTransaction ();
							return false;
						}
						Peer peer;
						if (qp.Count () == 0) {
							peer = new Peer {
								Address = clientUri,
								MAC_AddressHash = hash
							};
						} else {
							peer = qp.First ();
						}

						ctx.Peers.Add(peer);
						ctx.SaveChanges();
					}
					conn.CommitTransaction ();
					return true;
				} catch {
					conn.RollbackTransaction ();
					return false;
				}
			}
		}

		public bool kickoutPeer (string hash, string kickerHash)
		{
			using (MemoDbConnection conn = new MemoDbConnection ()) {	
				conn.BeginTransaction ();
				try { 
					using (MemoDbContext ctx = new MemoDbContext (conn.Connection, false)) {	
						var qp = from p in ctx.Peers
							where
							p.MAC_AddressHash.Equals (kickerHash)
							select p;

						if (qp.Count () != 1) {
							conn.CommitTransaction ();
							return false;
						}

						var qk = from p in ctx.Peers
							where
							p.MAC_AddressHash.Equals (kickerHash)
							select p;

						foreach(Peer p in qk){
							ctx.Peers.Remove(p);
						}
						ctx.SaveChanges();
					}
					conn.CommitTransaction ();
					return true;
				} catch {
					conn.RollbackTransaction ();
					return false;
				}
			}
		}

		public List<Uri> getPeerList ()
		{
			using (MemoDbConnection conn = new MemoDbConnection ()) {	
				conn.BeginTransaction ();
				try { 
					List<Uri> list = new List<Uri>();
					using (MemoDbContext ctx = new MemoDbContext (conn.Connection, false)) {	
						

						var qp = from p in ctx.Peers select p;

						foreach(Peer p in qp){

							list.Add(p.Address);
						}

					}
					conn.CommitTransaction ();
					return list;
				} catch {
					conn.RollbackTransaction ();
					return null;
				}
			}
		}
	}
}

