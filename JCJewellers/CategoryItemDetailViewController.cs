using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace JCJewellers
{
	public partial class CategoryItemDetailViewController : UIViewController
	{
		ItemDescriptionViewController itemDescriptionVC;
		public CategoryItemDetailViewController () : base ("CategoryItemDetailViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			List<String> names = new List<String> {"Item Category 1","Item Category 2","Item Category 3","Item Category 4","Item Category 5","Item Category 6","Item Category 7","Item Category 8","Item Category 9"};

			tableViewCategotyItemDetail.AutoresizingMask = UIViewAutoresizing.All;
			tableViewCategotyItemDetail.ScrollEnabled = true;
			tableViewCategotyItemDetail.Source = new CategoryItemDetailTableSource (names,this);
			tableViewCategotyItemDetail.BackgroundColor = UIColor.Gray;
			tableViewCategotyItemDetail.SeparatorInset = new UIEdgeInsets (0, 0, 0, 0);
			tableViewCategotyItemDetail.TableFooterView = new UIView (new RectangleF (0, 0, 100, 100)){BackgroundColor = UIColor.Clear};
			View.AddSubview (tableViewCategotyItemDetail);

		
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = false;

			this.Title = "Item Detail";

			NavigationController.NavigationBar.SetBackgroundImage (UIImage.FromFile ("navBg.jpg"), UIBarMetrics.Default);
			NavigationController.NavigationBar.SetTitleTextAttributes (new UITextAttributes {
				TextColor = UIColor.White,
				TextShadowColor = UIColor.FromRGBA (0, 0, 0, 0),
				TextShadowOffset = new UIOffset (0, 0),
			} );
		}

	}
}

