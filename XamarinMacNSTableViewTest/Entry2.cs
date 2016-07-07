using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace XamarinMacNSTableViewTest
{
	[Register("Entry2")]
	public class Entry2 : AppKit.NSTableCellView
	{
		#region Constructors

		// Called when created from unmanaged code
		public Entry2(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public Entry2(NSCoder coder) : base(coder)
		{
			Initialize();
		}

		// Shared initialization code
		void Initialize()
		{
		}

		#endregion

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			Console.WriteLine("AwakeFromNib. testLabel can't be set in IB for some reason");
		}
	}
}
