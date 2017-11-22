using System;
using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using Saafi.Core.Models;

namespace Saafi.iOS.Views
{
    public partial class AllRecipientsCell: MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(AllRecipientsCell));
        public static readonly UINib Nib;

        static AllRecipientsCell()
        {
            Nib = UINib.FromName("AllRecipientsCell", NSBundle.MainBundle);
        }

        protected AllRecipientsCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => {
                this.CreateBinding(RecipientNameLabel).To((Recipient vm) => vm.RecipientName).Apply();
                this.CreateBinding(RecipientPhoneNumberLabel).To((Send vm) => vm.CityName).Apply();
            });
        }
    }
}
