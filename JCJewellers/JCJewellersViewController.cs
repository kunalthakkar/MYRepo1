using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JCJewellers
{
	public partial class JCJewellersViewController : UIViewController
	{
		ContactUsViewController contactVC;
		CategoryViewController categoryVC;
		UIPageControl pageControl = new UIPageControl();
		public const int NUMBER_OF_PAGES = 3;

		UIView view1,view2,view3;
		UIScrollView scrollView;

		UIView[] mView = new UIView[3];
		public JCJewellersViewController () : base ("JCJewellersViewController", null)
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

			pageControl.Frame = new RectangleF (120, 230, 70, 50);
			pageControl.PageIndicatorTintColor = UIColor.FromRGB(246,180,2);
			pageControl.Pages = NUMBER_OF_PAGES;
			pageControl.CurrentPageIndicatorTintColor = UIColor.FromRGB(199,7,8);

			DisplayView1 ();
			DisplayView2 ();
			DisplayView3 ();

			scrollView = new UIScrollView (new RectangleF (0, 0, UIScreen.MainScreen.Bounds.Width, 277));
			scrollView.BackgroundColor = UIColor.LightGray;
			scrollView.ShowsHorizontalScrollIndicator = false;
			scrollView.ShowsVerticalScrollIndicator = false;
			scrollView.ScrollsToTop = false;
			scrollView.PagingEnabled = true;


			scrollView.ContentSize = new SizeF (scrollView.Frame.Size.Width * 3, scrollView.Frame.Size.Height);

			pageControl.SizeForNumberOfPages (NUMBER_OF_PAGES);
			pageControl.CurrentPage = 0;

			LoadScrollViewWithPage (2);
			LoadScrollViewWithPage (1);
			LoadScrollViewWithPage (0);

			scrollView.Scrolled += ScrollViewDidScroll;

			View.AddSubview (scrollView);
			View.Add (pageControl);

			JCInfoBtn.TouchUpInside += (sender, e) => {
				contactVC = new ContactUsViewController();
				this.NavigationController.PushViewController(contactVC,true);
			};

			silverBtn.TouchUpInside += (sender, e) => {
				categoryVC = new CategoryViewController();
				this.NavigationController.PushViewController(categoryVC,true);
			};

			goldBtn.TouchUpInside += (sender, e) => {
				categoryVC = new CategoryViewController();
				this.NavigationController.PushViewController(categoryVC,true);
			};

			jadtarBtn.TouchUpInside += (sender, e) => {
				categoryVC = new CategoryViewController();
				this.NavigationController.PushViewController(categoryVC,true);
			};

			diamondBtn.TouchUpInside += (sender, e) => {
				categoryVC = new CategoryViewController();
				this.NavigationController.PushViewController(categoryVC,true);
			};

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public void DisplayView1(){

			view1 = new UIView (new RectangleF (0, 0, UIScreen.MainScreen.Bounds.Width,  UIScreen.MainScreen.Bounds.Height));
			view1.BackgroundColor = UIColor.FromRGB(244,244,244);


			UIImageView img = new UIImageView (new RectangleF (0, 0, 320, 277));
			img.Image = UIImage.FromFile ("SamplePhoto.png");
			view1.AddSubview (img);

		}

		public void DisplayView2(){

			view2 = new UIView (new RectangleF (0, 0, UIScreen.MainScreen.Bounds.Width,  UIScreen.MainScreen.Bounds.Height));
			view2.BackgroundColor = UIColor.FromRGB(244,244,244);


			UIImageView img = new UIImageView (new RectangleF (0, 0, 320, 277));
			img.Image = UIImage.FromFile ("SamplePhoto.png");
			view2.AddSubview (img);

		}

		public void DisplayView3(){

			view3 = new UIView (new RectangleF (0, 0, UIScreen.MainScreen.Bounds.Width,  UIScreen.MainScreen.Bounds.Height));
			view3.BackgroundColor = UIColor.FromRGB(244,244,244);

			UIImageView img = new UIImageView (new RectangleF (0, 0, 320, 277));
			img.Image = UIImage.FromFile ("SamplePhoto.png");
			view3.AddSubview (img);

		}

		public void ScrollViewDidScroll (object sender, EventArgs e)
		{
			float pageWidth = scrollView.Frame.Size.Width;
			int page = (int)Math.Floor ((scrollView.ContentOffset.X - pageWidth / 2) / pageWidth) + 1;

			if (pageControl.CurrentPage != page) {
				PageDidAppear(page);

				pageControl.CurrentPage = page;

			}
		}

		private void PageDidAppear(int page) {
			if (page < NUMBER_OF_PAGES - 1) {
				UIView.Animate(0.5, () => { pageControl.Alpha = 1; }, null);
			}
		}

		protected void LoadScrollViewWithPage (int page)
		{
			if ((page < 0) || (page >= NUMBER_OF_PAGES))
				return;

			mView[page] = new UIView();

			if (page == 0) {
				mView [page].Add (view1);
			}else if (page == 1) {
				mView [page].Add (view2);
			}else if (page == 2) {
				mView [page].Add (view3);
			}
			float pageWidth = scrollView.Frame.Size.Width;
			mView [page].Frame = new RectangleF (page * pageWidth, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);                
			scrollView.Add (mView [page]);
		}
		public override void ViewDidLayoutSubviews ()
		{

			var height = UIScreen.MainScreen.Bounds.Height;
			if (height < 500) {
				//bottomContainer.Frame = new RectangleF (0, 420, 320, 60);
			
			}

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBar.Translucent = true;
			this.NavigationController.NavigationBarHidden = true;



		}

	}
}

