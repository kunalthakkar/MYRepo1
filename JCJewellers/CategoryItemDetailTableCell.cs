using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.MessageUI;
using System.Collections.Generic;

namespace JCJewellers
{
	public class CategoryItemDetailTableCell : UITableViewCell
	{
		CategoryItemDetailViewController categoryItemDetailVC;
		public CategoryItemDetailTableCell(CategoryItemDetailViewController _categoryItemDetailVC, string cellId) : base(UITableViewCellStyle.Subtitle, cellId)
		{
			categoryItemDetailVC = _categoryItemDetailVC;
		}

		public void intialize(List<String> names,NSIndexPath indexpath)
		{
			UILabel lblTitle = new UILabel (new RectangleF (20, 25, 200, 30));
			lblTitle.Text=names[indexpath.Row].ToString();
			lblTitle.Font = UIFont.FromName ("Helvetica", 15f);
			this.ContentView.AddSubview (lblTitle);

		}

	}
}

