using System;

namespace MemoServer
{
	public class Memo
	{
		public long Id {
			get;
			set;
		}
		public string Message {
			get;
			set;
		}

		public DateTime Timestamp {
			get;
			set;
		}

		public string Sender {
			get;
			set;
		}

		public bool Unread {
			get;
			set;
		}

		public Memo(string message, string sender)
		{
			this.Timestamp = DateTime.Now;
			this.Message = message;
			this.Sender = sender;
			this.Unread = true;
		}
	}
}

