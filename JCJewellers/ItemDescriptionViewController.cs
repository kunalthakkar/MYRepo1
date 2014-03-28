using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JCJewellers
{
	public partial class ItemDescriptionViewController : UIViewController
	{
		public ItemDescriptionViewController () : base ("ItemDescriptionViewController", null)
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


			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = false;

			this.Title = "Item Description";

			NavigationController.NavigationBar.SetBackgroundImage (UIImage.FromFile ("navBg.jpg"), UIBarMetrics.Default);
			NavigationController.NavigationBar.SetTitleTextAttributes (new UITextAttributes {
				TextColor = UIColor.White,
				TextShadowColor = UIColor.FromRGBA (0, 0, 0, 0),
				TextShadowOffset = new UIOffset (0, 0),
			} );

		}

	}
}

