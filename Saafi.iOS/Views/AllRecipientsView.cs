using System;
using System.Drawing;
using Foundation;
using MvvmCross.Binding.BindingContext;
using Saafi.Core.ViewModel;
using Saafi.iOS.TableViewSources;
using UIKit;
namespace Saafi.iOS.Views
{
    public partial class AllRecipientsView : BaseView
    {
        private AllRecipientsTableViewSource _allRecipientsTableViewSource;

        protected AllRecipientsViewModel AllRecipientsViewModel => ViewModel as AllRecipientsViewModel;
        public AllRecipientsView(IntPtr handle) : base(handle)
        {
        }
        protected override void CreateBindings()
        {
            base.CreateBindings();
            var set = this.CreateBindingSet<AllRecipientsView, AllRecipientsViewModel>();

            set.Bind(_allRecipientsTableViewSource).To((AllRecipientsViewModel vm) => vm.AllRecipients);

            set.Apply();
        }
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            _allRecipientsTableViewSource = new AllRecipientsTableViewSource(allRecipientsTableView);

            base.ViewDidLoad();

            allRecipientsTableView.Source = _allRecipientsTableViewSource;
            allRecipientsTableView.ReloadData();
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            AllRecipientsViewModel.ReloadDataCommand.Execute();
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}