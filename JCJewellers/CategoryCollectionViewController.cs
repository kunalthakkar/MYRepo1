using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JCJewellers
{
	public partial class CategoryCollectionViewController : UIViewController
	{
		CategoryItemDetailViewController categoryItemVC = new CategoryItemDetailViewController();
		UIScrollView scrollView;


		public CategoryCollectionViewController () : base ("CategoryCollectionViewController", null)
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

			scrollView = new UIScrollView (new RectangleF (0, 64, View.Bounds.Width, 400));
			scrollView.ContentSize= new SizeF(320, 1000);
			View.AddSubview (scrollView);

			int y = 0;
			for (int i = 0; i < 16; i++) {

				UIView view = new UIView (new RectangleF(0, y, 320, 50));
				view.BackgroundColor = UIColor.Green;
				scrollView.AddSubview (view);


				UIButton btn = UIButton.FromType (UIButtonType.RoundedRect);
				btn.Frame = new RectangleF (0,y,320,50);
				btn.SetTitle ("go to item list", UIControlState.Normal);
				scrollView.AddSubview (btn);

				btn.TouchUpInside += (sender, e) =>
				{
					this.NavigationController.PushViewController(categoryItemVC,true);
				}  ;

				UIView lineView = new UIView (new RectangleF(0,y + 52 , 320, 2));
				lineView.BackgroundColor = UIColor.Blue;
				scrollView.AddSubview (lineView);
				y = y + 54;
			}

			itemBtn.TouchUpInside += (sender, e) => {

			};

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = false;
			this.NavigationController.NavigationBar.TintColor = UIColor.White;

			this.Title = "New Collection";

			NavigationController.NavigationBar.SetBackgroundImage (UIImage.FromFile ("navBg.jpg"), UIBarMetrics.Default);
			NavigationController.NavigationBar.SetTitleTextAttributes (new UITextAttributes {
				TextColor = UIColor.White,
				TextShadowColor = UIColor.FromRGBA (0, 0, 0, 0),
				TextShadowOffset = new UIOffset (0, 0),
			} );
		}

	}
}

