﻿using System;
using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using Saafi.Core.Models;

namespace Saafi.iOS.Views
{
    public partial class RecipientCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(RecipientCell));
        public static readonly UINib Nib;

        static RecipientCell()
        {
            Nib = UINib.FromName("RecipientCell", NSBundle.MainBundle);
        }

        protected RecipientCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => {
                this.CreateBinding(RecipientNameLabel).To((Recipient vm) => vm.RecipientName).Apply();
                this.CreateBinding(RecipientPhoneNumberLabel).To((Send vm) => vm.CityName).Apply();
            });
        }
    }
}
