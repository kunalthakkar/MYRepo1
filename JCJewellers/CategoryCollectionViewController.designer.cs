// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace JCJewellers
{
	[Register ("CategoryCollectionViewController")]
	partial class CategoryCollectionViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView bottomContainer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView bottomImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton itemBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView titleView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (bottomContainer != null) {
				bottomContainer.Dispose ();
				bottomContainer = null;
			}

			if (titleView != null) {
				titleView.Dispose ();
				titleView = null;
			}

			if (bottomImage != null) {
				bottomImage.Dispose ();
				bottomImage = null;
			}

			if (itemBtn != null) {
				itemBtn.Dispose ();
				itemBtn = null;
			}
		}
	}
}
