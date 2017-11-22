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
    [Register ("SendView")]
    partial class SendView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField cityTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField countryTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField recipientTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton sendButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField serviceTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cityTextField != null) {
                cityTextField.Dispose ();
                cityTextField = null;
            }

            if (countryTextField != null) {
                countryTextField.Dispose ();
                countryTextField = null;
            }

            if (recipientTextField != null) {
                recipientTextField.Dispose ();
                recipientTextField = null;
            }

            if (sendButton != null) {
                sendButton.Dispose ();
                sendButton = null;
            }

            if (serviceTextField != null) {
                serviceTextField.Dispose ();
                serviceTextField = null;
            }
        }
    }
}