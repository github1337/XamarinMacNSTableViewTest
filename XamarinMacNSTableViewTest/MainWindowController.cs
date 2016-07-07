using System;

using Foundation;
using AppKit;

namespace XamarinMacNSTableViewTest
{
	public partial class MainWindowController : NSWindowController, INSTableViewDelegate, INSTableViewDataSource
	{
		public MainWindowController(IntPtr handle) : base(handle)
		{
		}

		[Export("initWithCoder:")]
		public MainWindowController(NSCoder coder) : base(coder)
		{
		}

		public MainWindowController() : base("MainWindow")
		{
		}

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
		}

		public new MainWindow Window
		{
			get { return (MainWindow)base.Window; }
		}

		public override void WindowDidLoad()
		{
			base.WindowDidLoad();

			tableView.Delegate = this;
			tableView.DataSource = this;

			//tableView.RegisterNib(NSNib.from
			tableView.RegisterNib(new NSNib("Entry", NSBundle.MainBundle), "Entry");
			tableView.RegisterNib(new NSNib("EntryCell", NSBundle.MainBundle), "EntryCell");
			tableView.RegisterNib(new NSNib("Entry3", NSBundle.MainBundle), "Entry3");
		}


		/*public nint GetRowCount(NSTableView tableView)
		{
			return 10;
		}

		public NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			return tableView.MakeView("Entry", this);
		}*/

		[Export("numberOfRowsInTableView:")]
		public nint GetRowCount(NSTableView tableView)
		{
			return 4;
		}

		[Export("tableView:viewForTableColumn:row:")]
		public NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			NSView v = null;
			switch (row) {
				case 0:
					v = tableView.MakeView("Entry", null);
					break;
				case 1:
					v = tableView.MakeView("EntryCell", null);
					break;
				case 2:
					v = tableView.MakeView("Entry2", null);
					break;
				case 3:
					v = tableView.MakeView("Entry3", null);
					//(v as Entry3).testLabel.StringValue = "alda";
					break;
			}

			return v;
		}


	}
}
