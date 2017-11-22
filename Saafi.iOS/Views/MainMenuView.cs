using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Saafi.Core.ViewModel;

namespace Saafi.iOS.Views
{
    /// <summary>
    /// Created with the code template View Controller.
    /// MvvmCross Class Mods:
    /// Change ineritance to MvxViewController<MainMenuViewModel>
    /// </summary>
    public partial class MainMenuView : MvxViewController<MenuViewModel>
    {
        public MainMenuView() : base(nameof(MainMenuView), null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        /// <summary>
        /// MvvmCross Mods:
        /// Add the data-binding code for MvvmCross here.
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // This establishes the same sort of data binding in code as what we did in Android's axml.
            // It means: Bind the TipLabel's default binding property (Text in this case) to the ViewModel's Tip property.
            // 2-way binding by default.
            this.CreateBinding(CreateRecipient).To((MenuViewModel vm) => vm.NavigateCreateRecipient).Apply();
            this.CreateBinding(AllRecipients).To((MenuViewModel vm) => vm.NavigateAllRecipients).Apply();
        }
    }
}