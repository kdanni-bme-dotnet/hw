using System;
using Gtk;
using System.Diagnostics;

namespace Chat_Xamarin_GUI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try {
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();

			} catch (Exception e) {
				Debugger.Log (0, Debugger.DefaultCategory, e.StackTrace.ToString ());
			}
		}
	}
}
