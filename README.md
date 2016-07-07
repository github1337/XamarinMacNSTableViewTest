I'm having trouble getting custom NSTableView Cells/Views in my Xamarin Mac project to work. The cells are rendered but their outlets are always `null`, even after `AwakeFromNib`.

I have tried the following:

* `NSTableCellView` in Table View XIB
* `NSView` in Table View XIB
* `NSView` custom instantiation
etc.

e.g.
`tableView.MakeView("Entry", null);` in `GetViewForItem` after `tableView.RegisterNib(new NSNib("Entry", NSBundle.MainBundle), "Entry");`
or `NSBundle.MainBundle.LoadNibNamed(name, null, out arr);`
Both didn't work.

Here's a Git repo with everything I tried
https://github.com/github1337/XamarinMacNSTableViewTest

The console output shows that the outlets are null.

Any help to get this working would be much appreciated.
Thanks in advance!
