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
	[Register ("CategoryViewController")]
	partial class CategoryViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView bottomContainer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView bottomImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton collectionBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton newArrivalBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (collectionBtn != null) {
				collectionBtn.Dispose ();
				collectionBtn = null;
			}

			if (newArrivalBtn != null) {
				newArrivalBtn.Dispose ();
				newArrivalBtn = null;
			}

			if (bottomContainer != null) {
				bottomContainer.Dispose ();
				bottomContainer = null;
			}

			if (bottomImage != null) {
				bottomImage.Dispose ();
				bottomImage = null;
			}
		}
	}
}
