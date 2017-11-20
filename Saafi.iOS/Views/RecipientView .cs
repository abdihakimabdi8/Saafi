using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Localization;
using Saafi.Core.Converters;
using Saafi.Core.ViewModel;
using Saafi.iOS.Utility;
using UIKit;
using Saafi.Core.Model;
using Saafi.iOS;
using System.Drawing;
using Foundation;

namespace Saafi.iOS.Views
{
    [Register("RecipientView")]
    public partial class RecipientView : BaseView
    {
        protected RecipientViewModel RecipientViewModel
            => ViewModel as RecipientViewModel;

        public RecipientView(IntPtr handle) : base(handle)
        {
            Title = "Recipient";
        }
        //        Recipient _recipient;
        //}

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CloseButton.Layer.BorderWidth = 1;
            CloseButton.Layer.BorderColor = SaafiColors.AccentColor.CGColor;

            this.CreateBinding(RecipientNameLabel).For(label => label.Text).To((RecipientViewModel vm) => vm.RecipientName).Apply();
            this.CreateBinding(RecipientPhoneNumberLabel).For(label => label.Text).To((RecipientViewModel vm) => vm.RecipientPhoneNumber).Apply();

            this.CreateBinding(CreateRecipientButton).To((RecipientViewModel vm) => vm.SaveRecipient).Apply();


            this.CreateBinding(CloseButton).To((RecipientViewModel vm) => vm.CloseCommand).Apply();
            //set.Apply();
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                recipientNameTextField.ResignFirstResponder();
                recipientPhoneNumberTextField.ResignFirstResponder();
                //CreateRecipientButton.ResignFirstResponder();


            }));

            var g = new UITapGestureRecognizer(() => View.EndEditing(true));
            g.CancelsTouchesInView = false; //for iOS5
            View.AddGestureRecognizer(g);
            //Perform any additional setup after loading the view, typically from a nib.   
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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