// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinMacNSTableViewTest
{
	[Register ("Entry3")]
	partial class Entry3
	{
		[Outlet]
		AppKit.NSTextField testLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (testLabel != null) {
				testLabel.Dispose ();
				testLabel = null;
			}
		}
	}
}
