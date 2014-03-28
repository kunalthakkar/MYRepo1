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
	[Register ("JCJewellersViewController")]
	partial class JCJewellersViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView bottomContainer { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton diamondBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton goldBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton jadtarBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton JCInfoBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton silverBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (bottomContainer != null) {
				bottomContainer.Dispose ();
				bottomContainer = null;
			}

			if (diamondBtn != null) {
				diamondBtn.Dispose ();
				diamondBtn = null;
			}

			if (goldBtn != null) {
				goldBtn.Dispose ();
				goldBtn = null;
			}

			if (jadtarBtn != null) {
				jadtarBtn.Dispose ();
				jadtarBtn = null;
			}

			if (JCInfoBtn != null) {
				JCInfoBtn.Dispose ();
				JCInfoBtn = null;
			}

			if (silverBtn != null) {
				silverBtn.Dispose ();
				silverBtn = null;
			}
		}
	}
}
