﻿using System;
using Gtk;
using V37ZEN.Datagram;
using System.Diagnostics;
using System.ServiceModel;

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

		Datagram d = new Datagram ();
		d.Timestamp = DateTime.UtcNow;
		d.Message = text;
		d.Metadata = "HW!";

		try {

			using(DatagramServiceClient client = new DatagramServiceClient("DatagramClientUdpEndpoint")){

				client.ProcessDatagram(d);
			}

		} catch (Exception ex) {
			Debugger.Log (0, Debugger.DefaultCategory, ex.Message + '\n' + ex.StackTrace.ToString ());
		}

	}
}
