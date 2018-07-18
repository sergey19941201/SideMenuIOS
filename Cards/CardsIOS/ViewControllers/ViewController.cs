using System;
using System.Drawing;
using System.Threading;
using SidebarNavigation;
using UIKit;

namespace CardsIOS
{
	public partial class ViewController : UIViewController
    {
		System.Timers.Timer timer;
		public SidebarController SidebarController { get; set; }
		public static UINavigationController navigationController;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			navigationController = this.NavigationController;
			this.NavigationController.NavigationBarHidden = true;
            // Perform any additional setup after loading the view, typically from a nib.
			splashIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 5, Convert.ToInt32(View.Frame.Height) / 3, (Convert.ToInt32(View.Frame.Width) / 5)*3, Convert.ToInt32(View.Frame.Width) / 2);

			//Thread.Sleep(10000);

			//var onBoarding1ViewController = new OnBoarding1ViewController(handle);
			//var mainController = new UIViewController(); // Your view controller here
			//UIApplication.SharedApplication.KeyWindow.RootViewController = mainController;
			//this.NavigationController.PushViewController(onBoarding1ViewController, true); 



			//var first = new UIViewController();

			// wrap your VC inside a Nav controller
			//var nav = new UINavigationController(first);
			var sb = UIStoryboard.FromName("Main", null);
            
            

			/*var menu = sb.InstantiateViewController("MenuButtonsController");
			var contentVC = sb.InstantiateViewController("MyCardViewController");
			SidebarController = new SidebarController(this,menu,menu);

            SidebarController.HasShadowing = false;
            SidebarController.MenuWidth = 310;
            SidebarController.MenuLocation = MenuLocations.Left;
			((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController = SidebarController;
*/
			//mainController.PushViewController(onBoarding1ViewController, true);
			var vc = sb.InstantiateViewController("OnBoarding1ViewController");
			timer = new System.Timers.Timer();
            timer.Interval = 1500;
			timer.Elapsed += delegate
			{
				timer.Stop();
				timer.Dispose();
				InvokeOnMainThread(() => { this.NavigationController.PushViewController(vc, true); });
			};
			timer.Start();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
