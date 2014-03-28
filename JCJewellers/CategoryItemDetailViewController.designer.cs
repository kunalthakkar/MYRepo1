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
	[Register ("CategoryItemDetailViewController")]
	partial class CategoryItemDetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITableView tableViewCategotyItemDetail { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableViewCategotyItemDetail != null) {
				tableViewCategotyItemDetail.Dispose ();
				tableViewCategotyItemDetail = null;
			}
		}
	}
}
