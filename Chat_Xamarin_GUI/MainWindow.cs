using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		
	protected void Exit (object sender, EventArgs e)
	{
		Application.Quit ();
	}

	protected void handleButton (object sender, EventArgs e)
	{
		Send ();
		this.chatField.GrabFocus ();
	}

	protected void handleEnterPressed (object sender, EventArgs e)
	{
		Send ();
	}

	public void Send(){
		var text = this.chatField.Text + '\n';
		this.chatField.Text = "";

		this.chatLog.Buffer.InsertAtCursor (text);
	}
}
