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

		[Export("numberOfRowsInTableView:")]
		public nint GetRowCount(NSTableView tableView)
		{
			return 5;
		}

		[Export("tableView:heightOfRow:")]
		public nfloat GetRowHeight(NSTableView tableView, nint row)
		{
			return 50;
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
					break;
				case 4:
					v = tableView.MakeView("Entry4", null);
					if (v == null) {
						v = GetViewFromNib<Entry4>("Entry4");
					}
					break;
			}

			return v;
		}




		public static T GetViewFromNib<T>(string name) where T : NSObject
		{
			T view = null;
			var arr = new NSArray();
			bool viewWasFound = false;
			NSBundle.MainBundle.LoadNibNamed(name, null, out arr);
			for (nuint i = 0; i < arr.Count; i++)
			{
				var vv = arr.ValueAt(i);
				var v = ObjCRuntime.Runtime.GetNSObject<NSObject>(vv);
				if (v is T)
				{
					view = v as T;
					viewWasFound = true;
					break;
				}
			}

			if (!viewWasFound)
			{
				throw new Exception("View with this nib name was not found");
			}
			return view;
		}
	}

}
