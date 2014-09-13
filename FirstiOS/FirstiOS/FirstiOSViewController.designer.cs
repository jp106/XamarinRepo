// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FirstiOS
{
	[Register ("FirstiOSViewController")]
	partial class FirstiOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelListitems { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelSyllabus { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (labelListitems != null) {
				labelListitems.Dispose ();
				labelListitems = null;
			}
			if (labelSyllabus != null) {
				labelSyllabus.Dispose ();
				labelSyllabus = null;
			}
		}
	}
}
