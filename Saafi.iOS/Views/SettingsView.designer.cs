// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Saafi.iOS.Views
{
    [Register ("SettingsView")]
    partial class SettingsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CurrencyTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView testTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VisitSiteButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CurrencyTextField != null) {
                CurrencyTextField.Dispose ();
                CurrencyTextField = null;
            }

            if (testTextView != null) {
                testTextView.Dispose ();
                testTextView = null;
            }

            if (VisitSiteButton != null) {
                VisitSiteButton.Dispose ();
                VisitSiteButton = null;
            }
        }
    }
}