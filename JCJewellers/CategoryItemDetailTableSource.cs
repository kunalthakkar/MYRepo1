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
	public class CategoryItemDetailTableSource :UITableViewSource
	{
		List<String> names;
		string cellIdentifier = "TableCell";
		CategoryItemDetailViewController categoryItemDetailVC;
		ItemDescriptionViewController itemDescriptionVC;
		public CategoryItemDetailTableSource (List<String> _names,CategoryItemDetailViewController _categoryItemDetailVC)
		{
			names = _names;
			categoryItemDetailVC = _categoryItemDetailVC;
		}



		public override int RowsInSection (UITableView tableview, int section)
		{
			return names.Count;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			itemDescriptionVC = new ItemDescriptionViewController();
			categoryItemDetailVC.NavigationController.PushViewController(itemDescriptionVC,true);
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 70;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			string cellID = "Cell";

			CategoryItemDetailTableCell cell = (CategoryItemDetailTableCell)tableView.DequeueReusableCell(cellID);
			//if (cell == null)
					cell = new CategoryItemDetailTableCell(categoryItemDetailVC, cellID);
			cell.BackgroundColor = UIColor.Clear;
			cell.intialize(names,indexPath);
			return cell;
		}
	}
}

