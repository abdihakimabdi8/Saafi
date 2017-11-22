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
    [Register ("MainMenuView")]
    partial class MainMenuView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AllRecipients { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CreateRecipient { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AllRecipients != null) {
                AllRecipients.Dispose ();
                AllRecipients = null;
            }

            if (CreateRecipient != null) {
                CreateRecipient.Dispose ();
                CreateRecipient = null;
            }
        }
    }
}