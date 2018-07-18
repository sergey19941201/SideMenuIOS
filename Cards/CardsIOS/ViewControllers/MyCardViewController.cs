using Foundation;
using System;
using System.Drawing;
using UIKit;
using SidebarNavigation;

namespace CardsIOS
{
    public partial class MyCardViewController : UIViewController
    {
		public SidebarController SidebarController { get; private set; }
		public SidebarController SideBarController;
        public UIViewController holderVC;
		IntPtr handle;
        public MyCardViewController (IntPtr handle) : base (handle)
        {
			this.handle = handle;
        }
		public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			// create a slideout navigation controller with the top navigation controller and the menu view controller
			//SidebarController = new SidebarController(this, new MyCardViewController(handle), new OnBoarding1ViewController(handle));
			SidebarController = ((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController;

			var deviceModel = Xamarin.iOS.DeviceHardware.Model;
            //this.NavigationController.NavigationBarHidden = true;
            // Perform any additional setup after loading the view, typically from a nib.
            backgroundIV.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height));

            cardsLogo.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 3,
                                            Convert.ToInt32(View.Frame.Width) / 3,
                                            Convert.ToInt32(View.Frame.Width) / 3,
                                            Convert.ToInt32(View.Frame.Width) / 3);
            mainTextLabel.Frame = new Rectangle(0, (Convert.ToInt32(cardsLogo.Frame.X) + Convert.ToInt32(View.Frame.Width) / 3) + 35, Convert.ToInt32(View.Frame.Width), 70);
            //var d = cardsLogo.Frame.X;
			mainTextLabel.Text = "Создайте \r\n первую визитку";
			mainTextLabel.Font = mainTextLabel.Font.WithSize(22f);
			infoLabel.Lines = 2;
            infoLabel.Text = "Заполняйте личные" + "\r\n" + "и корпоративные данные," + "\r\n" + "добавляйте лого компании";

            infoLabel.Lines = 3;
			infoLabel.Frame = new Rectangle(0, Convert.ToInt32(mainTextLabel.Frame.Y) + 60, Convert.ToInt32(View.Frame.Width), 100);
            createBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 15,
                                         (Convert.ToInt32(View.Frame.Height) / 10) * 8,
                                         Convert.ToInt32(View.Frame.Width) - ((Convert.ToInt32(View.Frame.Width) / 15) * 2),
                                         Convert.ToInt32(View.Frame.Height) / 12);
			createBn.Font = mainTextLabel.Font.WithSize(17f);
			  
			if (deviceModel.Contains("X"))
			{
				headerView.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), (Convert.ToInt32(View.Frame.Height) / 10)+8); 
				leftMenuBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 18, (Convert.ToInt32(View.Frame.Width) / 12)+20, Convert.ToInt32(View.Frame.Width) / 16, Convert.ToInt32(View.Frame.Width) / 19);
                plusBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(leftMenuBn.Frame.Width) + (Convert.ToInt32(View.Frame.Width) / 18)),
				                             (Convert.ToInt32(View.Frame.Width) / 12)+20,
                                             Convert.ToInt32(View.Frame.Width) / 18,
                                             Convert.ToInt32(View.Frame.Width) / 18);
				headerLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 5, (Convert.ToInt32(View.Frame.Width) / 12)+20, (Convert.ToInt32(View.Frame.Width) / 5) * 3, Convert.ToInt32(View.Frame.Width) / 18);
			}
			else
			{        
				headerView.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), (Convert.ToInt32(View.Frame.Height) / 10)); 
				leftMenuBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 18, Convert.ToInt32(View.Frame.Width) / 12, Convert.ToInt32(View.Frame.Width) / 16, Convert.ToInt32(View.Frame.Width) / 19);
				plusBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(leftMenuBn.Frame.Width) + (Convert.ToInt32(View.Frame.Width) / 18)),
											 Convert.ToInt32(View.Frame.Width) / 12,
											 Convert.ToInt32(View.Frame.Width) / 18,
											 Convert.ToInt32(View.Frame.Width) / 18);
				headerLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 5, Convert.ToInt32(View.Frame.Width) / 12, (Convert.ToInt32(View.Frame.Width) / 5) * 3, Convert.ToInt32(View.Frame.Width) / 18);
			}
			headerLabel.Text = "Моя визитка";


			var i = this.NavigationController;


			/*UIStoryboard sb = UIStoryboard.FromName("Main", NSBundle.MainBundle);

			SideMenuViewController menuVC = (SideMenuViewController)sb.InstantiateViewController("SideMenuViewController");



			ContentViewController contentVC = (ContentViewController)sb.InstantiateViewController("ContentVC");

			SidebarController = new SidebarController(this, contentVC, menuVC);
            SidebarController.MenuLocation = MenuLocations.Left;
            SidebarController.MenuWidth = Convert.ToInt32(View.Frame.Width - 30);
            contentVC.SideBarController = SidebarController;
            contentVC.holderVC = this;
			/*var sb = UIStoryboard.FromName("Main", null);
            var vc = sb.InstantiateViewController("OnBoarding1ViewController");
			var menu = sb.InstantiateViewController("MenuButtonsController");
            var contentVC = sb.InstantiateViewController("MyCardViewController");
			//SidebarController = new SidebarController(this, menu, menu);

            SidebarController.HasShadowing = false;
            SidebarController.MenuWidth = 210;
            SidebarController.MenuLocation = MenuLocations.Left;
            //((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController = SidebarController;

			plusBn.TouchUpInside += (s, e) =>
			  {
				if (SidebarController == null)
                      return;
                  SidebarController.ToggleMenu();
			  };*/
			leftMenuBn.TouchUpInside += (s, e) => 
			{
				/*SidebarController = new SidebarController(this, menu, menu);
				SidebarController.HasShadowing = false;
                SidebarController.MenuWidth = 210;
                SidebarController.MenuLocation = MenuLocations.Left;*/
				/*if (SidebarController == null)
                    return;*/
				//SidebarController.ToggleMenu();
				RootMyCardViewController.SidebarController.ToggleMenu();
            };

			/*createBn.TouchUpInside += (s, e) =>
            {
                /*if (mainTextTV.Text == "Создавайте визитки")
                {
                    mainTextTV.Text = "Делитесь с партнерами";
                    infoLabel.Text = "Предложите вашему партнеру"
                        + "\r\n" + "отсканировать QR-код с визитки"
                        + "\r\n" + "и сохранить контактную информацию";
                    cardsLogo.Image = UIImage.FromBundle("onBoard2Logo");
                }
                else if (mainTextTV.Text == "Делитесь с партнерами")
                {
                    mainTextTV.Text = "Заказывайте наклейки";
                    infoLabel.Text = "Делитесь QR-кодом"
                        + "\r\n" + "как из приложения, так"
                        + "\r\n" + "и со специальной QR наклейки";
                    cardsLogo.Image = UIImage.FromBundle("onBoard3Logo");
                }*/
            //};
        }
    }
}