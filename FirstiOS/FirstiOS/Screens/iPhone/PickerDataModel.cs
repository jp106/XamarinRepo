using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace FirstiOS
{
	public class PickerDataModel:UIPickerViewModel
	{
		public PickerDataModel ()
		{

			Items.Add (UIColor.Red);
		    Items.Add (UIColor.Black);
			Items.Add (UIColor.Brown);

		}
		public event EventHandler<EventArgs> ValueChanged;

		/// <summary>
		/// The color we wish to display
		/// </summary>
		public List<UIColor> Items
		{
			get { return items; }
			set { items = value; }
		}
		List<UIColor> items = new List<UIColor>();

		/// <summary>
		/// The current selected item
		/// </summary>
		public UIColor SelectedItem
		{
			get { return items[selectedIndex]; }
		}
		protected int selectedIndex = 0;
		/// <summary>
		/// Called by the picker to determine how many rows are in a given spinner item
		/// </summary>
		public override int GetRowsInComponent (UIPickerView picker, int component)
		{
			return items.Count;
		}

		/// <summary>
		/// called by the picker to get the number of spinner items
		/// </summary>
		public override int GetComponentCount (UIPickerView picker)
		{
			return 2;
		}

		/// <summary>
		/// called when a row is selected in the spinner
		/// </summary>
		public override void Selected (UIPickerView picker, int row, int component)
		{
			selectedIndex = row;
			if (this.ValueChanged != null)
			{
				this.ValueChanged (this, new EventArgs ());
			}	
		}

		/// <summary>
		/// Custom row view. 
		/// 
		/// The <c>view</c> param is the reusable view for the row. It will be null initially.
		/// 
		/// You can add subviews, etc., but prefer to do that in the lazy-initialization block rather
		/// than every time this method is called. 
		/// 
		/// Note that GetTitle() is no longer overridden since we aren't using the default row view
		/// </summary>
		public override UIView GetView(UIPickerView picker, int row, int component, UIView view)
		{
			//Lazy initialize
			if(view == null)
			{
			}
			//Modify state to reflect data
		//	view.BackgroundColor = items[row];
			return view;
		}

		/// <summary>
		/// Make the rows in the second component half the size of those in the first
		/// </summary>
		public override float GetRowHeight(UIPickerView picker, int component)
		{
			return 44 / (component % 2 + 1);
		}
	}
}

