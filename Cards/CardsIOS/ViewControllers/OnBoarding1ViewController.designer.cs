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

namespace CardsIOS
{
    [Register ("OnBoarding1ViewController")]
    partial class OnBoarding1ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView backgroundIV { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView cardsLogo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infoLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel mainTextTV { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton nextBn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (backgroundIV != null) {
                backgroundIV.Dispose ();
                backgroundIV = null;
            }

            if (cardsLogo != null) {
                cardsLogo.Dispose ();
                cardsLogo = null;
            }

            if (infoLabel != null) {
                infoLabel.Dispose ();
                infoLabel = null;
            }

            if (mainTextTV != null) {
                mainTextTV.Dispose ();
                mainTextTV = null;
            }

            if (nextBn != null) {
                nextBn.Dispose ();
                nextBn = null;
            }
        }
    }
}