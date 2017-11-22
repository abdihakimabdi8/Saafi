using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Saafi.Core.ViewModel;
using UIKit;

namespace Saafi.iOS.Views
{
    /// <summary>
    /// Created with the code template View Controller.
    /// MvvmCross Class Mods:
    /// Change ineritance to MvxViewController<BillViewModel>
    /// </summary>
    public partial class RecipientView : MvxViewController<RecipientViewModel>
    {
        public RecipientView() : base(nameof(RecipientView), null)
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
            // It means: Bind the VCEmail's default binding property (Text in this case) 
            // to the ViewModel's CustomerEmail property.
            // 2-way binding by default.
            this.CreateBinding(recipientNameTextField).To((RecipientViewModel vm) => vm.RecipientName).Apply();

            // This is a similar example, but demonstrates binding to a specific property (Text).
            this.CreateBinding(recipientPhoneNumberTextField).To((RecipientViewModel vm) => vm.RecipientPhoneNumber).Apply();
            this.CreateBinding(CreateRecipientButton).To((RecipientViewModel vm) => vm.SaveRecipient).Apply();

            // This ensures that the virtual keyboard is closed after text input.
            View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
                this.recipientNameTextField.ResignFirstResponder();
                this.recipientPhoneNumberTextField.ResignFirstResponder();

            }));
        }
    }
}