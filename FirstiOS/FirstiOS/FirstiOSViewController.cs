using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FirstiOS
{
	public partial class FirstiOSViewController : UIViewController
	{
		private string firstYearString = "Tukadas 1-4 \n Tihai 1/2 \n Chakradhar Tukda 1 \n";
		private string secondYearString = "Tukadas 1/2 \n Tihai 1/2 \n Chakradhar Tihai/Tukda 2 \n " +
			"Paran 1/2 \n Palta 1-6 \n Gat \n Thaat \n Aamad \n Rangmanch Pranaam";
		private string thirdYearString = "Palta 7/8 \n Paran Aamad \n Kavit \n Gat kavit ";

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public FirstiOSViewController (IntPtr handle) : base (handle)
		{
			_buttons = new List<UIButton> ();
		}
	
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle
		PickerDataModel pickerDataModel;
		UIScrollView _scrollViewSyllabus;
		UIScrollView _scrollViewYear;
		List<UIButton> _buttons;
		UIPickerView pickeritems;
		float h = 50.0f;
		float w = 50.0f;
		float padding = 5.0f;
		int n = 4;
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			pickerDataModel = new PickerDataModel ();

			// set our initial selection on the label
			this.labelListitems.Text = pickerDataModel.SelectedItem.ToString();

			_scrollViewSyllabus = new UIScrollView {
				Frame = new RectangleF (0, 100, View.Frame.Width,
					h + 2 * padding),
				ContentSize = new SizeF ((w + padding) * n, h),
				BackgroundColor = UIColor.Orange,
				AutoresizingMask = UIViewAutoresizing.FlexibleWidth
			};
			_scrollViewYear = new UIScrollView {
				Frame = new RectangleF (0, 20, View.Frame.Width,
					h + 2 * padding),
				ContentSize = new SizeF ((w + padding) * n, h),
				BackgroundColor = UIColor.Orange,
				AutoresizingMask = UIViewAutoresizing.FlexibleWidth
			};

			PreapareScrollers ();
			//View.AddSubviews (pickeritems);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		private void PreapareScrollers()
		{
			Tukda.AddAllButtons ();
			for (int i=1; i<4; i++) {

				var button = UIButton.FromType (UIButtonType.RoundedRect);
				button.SetTitle (i.ToString() + " Year", UIControlState.Normal);

				button.Frame = new RectangleF (padding * (i + 1) + (i * w),
					padding, w, h);
				button.TouchUpInside += (s, e) => {
					int c = 3;
					if (button.TitleLabel.Text=="1 Year") {
						c = Tukda.firstlist.Capacity;
					}else	if (button.TitleLabel.Text =="2 Year") {
						c = Tukda.secondlist.Capacity;
					}else	if (button.TitleLabel.Text =="3 Year") {
						c = Tukda.thirdlist.Capacity;
					}

					PurgeViews();

					for (int l=0; l<c; l++) {
						var btn = new ButtonItem("","");

						if (button.TitleLabel.Text=="1 Year") {
							btn = Tukda.GetFirstYearSyllabus(l);
						}else if (button.TitleLabel.Text =="2 Year") {
							btn = Tukda.GetSecondYearSyllabus(l);
						}else if (button.TitleLabel.Text =="3 Year") {
							btn = Tukda.GetThirdYearSyllabus(l);
						}

						btn.Frame = new RectangleF (padding * (l + 1) + (l * 80.0f),
							padding, w, h);

						btn.TouchUpInside += (obj, EventArgs) => {
							labelListitems.Text = btn.Bol;
						};
						_scrollViewSyllabus.AddSubview (btn);
						_buttons.Add (btn);
					}
				};
				_scrollViewYear.AddSubview (button);

				_buttons.Add (button);
			}

			pickeritems = new UIPickerView {Frame = new RectangleF (50, 50, View.Frame.Width,
				h + 2 * padding)};

			pickeritems.Source = pickerDataModel;


			// wire up the value change method
			pickerDataModel.ValueChanged += (s, e) => {
				this.labelListitems.Text = pickerDataModel.SelectedItem.ToString();
			};
			View.AddSubview (_scrollViewSyllabus);
			View.AddSubview (_scrollViewYear);

		}

		private void PurgeViews()
		{
			foreach (var view in _scrollViewSyllabus.Subviews) {

				view.RemoveFromSuperview();


			}
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}



		#endregion
	}
}

