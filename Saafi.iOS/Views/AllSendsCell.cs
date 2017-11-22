using System;
using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using Saafi.Core.Models;

namespace Saafi.iOS.Views
{
    public partial class AllSendsCell: MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(AllSendsCell));
        public static readonly UINib Nib;

        static AllSendsCell()
        {
            Nib = UINib.FromName("AllSendsCell", NSBundle.MainBundle);
        }

        protected AllSendsCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => {
                this.CreateBinding(recipientLabel).To((Send vm) => vm.RecipientName).Apply();
                this.CreateBinding(cityLabel).To((Send vm) => vm.CityName).Apply();
                this.CreateBinding(countryLabel).To((Send vm) => vm.CountryName).Apply();
                this.CreateBinding(serviceLabel).To((Send vm) => vm.ServiceName).Apply();
            });
        }
    }
}
