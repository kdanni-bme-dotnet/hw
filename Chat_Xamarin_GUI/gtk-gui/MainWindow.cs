
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action quitAction;
	
	private global::Gtk.Notebook notebook2;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView chatLog;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow2;
	
	private global::Gtk.TextView userList;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Entry chatField;
	
	private global::Gtk.Button sendButton;
	
	private global::Gtk.Statusbar statusbar1;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.ScrolledWindow scrolledwindow2;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Button button2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.notebook2 = new global::Gtk.Notebook ();
		this.notebook2.CanFocus = true;
		this.notebook2.Name = "notebook2";
		this.notebook2.CurrentPage = 0;
		this.notebook2.ShowBorder = false;
		this.notebook2.ShowTabs = false;
		// Container child notebook2.Gtk.Notebook+NotebookChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name=\'menubar1\'><menu name=\'FileAction\' action=\'FileAction\'><menuite" +
		"m name=\'quitAction\' action=\'quitAction\'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox2.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.chatLog = new global::Gtk.TextView ();
		this.chatLog.CanFocus = true;
		this.chatLog.Name = "chatLog";
		this.chatLog.Editable = false;
		this.chatLog.CursorVisible = false;
		this.chatLog.LeftMargin = 4;
		this.chatLog.RightMargin = 4;
		this.GtkScrolledWindow1.Add (this.chatLog);
		this.hbox1.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow1]));
		w4.Position = 0;
		w4.Padding = ((uint)(4));
		// Container child hbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow2.WidthRequest = 100;
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.userList = new global::Gtk.TextView ();
		this.userList.CanFocus = true;
		this.userList.Name = "userList";
		this.userList.Editable = false;
		this.userList.CursorVisible = false;
		this.userList.Justification = ((global::Gtk.Justification)(1));
		this.GtkScrolledWindow2.Add (this.userList);
		this.hbox1.Add (this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Padding = ((uint)(4));
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w7.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.chatField = new global::Gtk.Entry ();
		this.chatField.CanFocus = true;
		this.chatField.Name = "chatField";
		this.chatField.IsEditable = true;
		this.chatField.InvisibleChar = '●';
		this.hbox2.Add (this.chatField);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.chatField]));
		w8.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.sendButton = new global::Gtk.Button ();
		this.sendButton.CanFocus = true;
		this.sendButton.Name = "sendButton";
		this.sendButton.UseUnderline = true;
		this.sendButton.Label = global::Mono.Unix.Catalog.GetString ("Send");
		this.hbox2.Add (this.sendButton);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.sendButton]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		w9.Padding = ((uint)(4));
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox2.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar1]));
		w11.Position = 3;
		w11.Expand = false;
		w11.Fill = false;
		this.notebook2.Add (this.vbox2);
		// Notebook tab
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Stert Page");
		this.notebook2.SetTabLabel (this.vbox2, this.label3);
		this.label3.ShowAll ();
		// Container child notebook2.Gtk.Notebook+NotebookChild
		this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow2.CanFocus = true;
		this.scrolledwindow2.Name = "scrolledwindow2";
		this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow2.Gtk.Container+ContainerChild
		global::Gtk.Viewport w13 = new global::Gtk.Viewport ();
		w13.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.table1.Add (this.button2);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.button2]));
		w14.TopAttach = ((uint)(1));
		w14.BottomAttach = ((uint)(2));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		w13.Add (this.table1);
		this.scrolledwindow2.Add (w13);
		this.notebook2.Add (this.scrolledwindow2);
		global::Gtk.Notebook.NotebookChild w17 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2 [this.scrolledwindow2]));
		w17.Position = 1;
		this.Add (this.notebook2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.quitAction.Activated += new global::System.EventHandler (this.Exit);
		this.chatField.Activated += new global::System.EventHandler (this.handleEnterPressed);
		this.sendButton.Pressed += new global::System.EventHandler (this.handleButton);
	}
}