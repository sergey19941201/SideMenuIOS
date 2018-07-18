using Foundation;
using SidebarNavigation;
using System;
using UIKit;

namespace CardsIOS
{
    public partial class RootMyCardViewController : UIViewController
    {
		public static SidebarController SidebarController;
		public RootMyCardViewController(IntPtr handle) : base(handle)
        {
			
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SidebarController = ((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController;         
			UIStoryboard sb = UIStoryboard.FromName("Main", NSBundle.MainBundle);         
            SideMenuViewController menuVC = (SideMenuViewController)sb.InstantiateViewController("SideMenuViewController");
            MyCardViewController contentVC = (MyCardViewController)sb.InstantiateViewController("MyCardViewController");

            SidebarController = new SidebarController(this, contentVC, menuVC);
            SidebarController.MenuLocation = MenuLocations.Left;
			SidebarController.MenuWidth = Convert.ToInt32(View.Frame.Width - Convert.ToInt32(View.Frame.Width)/6);
            contentVC.SideBarController = SidebarController;
            contentVC.holderVC = this;
        }
    }
}