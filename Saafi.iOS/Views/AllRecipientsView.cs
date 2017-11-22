using UIKit;
using Foundation;
using MvvmCross.iOS.Views;
using Saafi.Core.ViewModel;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace Saafi.iOS.Views
{
    [Register(nameof(AllRecipientsView))]
    public class AllRecipientsView : MvxViewController<AllRecipientsViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var tableView = new UITableView(UIScreen.MainScreen.Bounds, UITableViewStyle.Plain);
            tableView.RowHeight = 150;
            Add(tableView);

            var source = new MvxSimpleTableViewSource(tableView, RecipientCell.Key, RecipientCell.Key);
            tableView.Source = source;

            this.CreateBinding(source).To((AllRecipientsViewModel vm) => vm.AllRecipients).Apply();
            tableView.ReloadData();
        }
    }
}