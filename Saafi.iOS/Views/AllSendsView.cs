using UIKit;
using Foundation;
using MvvmCross.iOS.Views;
using Saafi.Core.ViewModel;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace Saafi.iOS.Views
{
    [Register(nameof(AllSendsView))]
    public class AllSendsView : MvxViewController<AllRecipientsViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var tableView = new UITableView(UIScreen.MainScreen.Bounds, UITableViewStyle.Plain);
            tableView.RowHeight = 150;
            Add(tableView);

            var source = new MvxSimpleTableViewSource(tableView, AllSendsCell.Key, AllSendsCell.Key);
            tableView.Source = source;

            this.CreateBinding(source).To((AllSendsViewModel vm) => vm.AllSends).Apply();
            tableView.ReloadData();
        }
    }
}