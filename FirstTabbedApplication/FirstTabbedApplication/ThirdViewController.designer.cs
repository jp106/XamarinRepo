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

namespace FirstTabbedApplication
{
	[Register ("ThirdViewController")]
	partial class ThirdViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelListitems { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (labelListitems != null) {
				labelListitems.Dispose ();
				labelListitems = null;
			}
		}
	}
}
