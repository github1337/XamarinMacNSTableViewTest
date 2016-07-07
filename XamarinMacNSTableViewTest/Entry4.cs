using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace XamarinMacNSTableViewTest
{
	public partial class Entry4 : AppKit.NSView
	{
		#region Constructors

		// Called when created from unmanaged code
		public Entry4(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public Entry4(NSCoder coder) : base(coder)
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
			Console.WriteLine("AwakeFromNib. this: {0}, testLabel: {1}", this, testLabel == null ? "null" : "not null");
		}
	}
}
