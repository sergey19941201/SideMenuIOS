using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace CardsIOS
{
    public partial class SideMenuViewController : UIViewController
    {
		public SideMenuViewController (IntPtr handle/*, UINavigationController navigationController*/) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//var l = this.NavigationController;
			splashIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 8,
                                         (Convert.ToInt32(View.Frame.Height) / 10),
			                              (Convert.ToInt32(View.Frame.Height) / 6)+15,
                                         Convert.ToInt32(View.Frame.Height) / 6);
			myCardIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width / 20) ,
			                               Convert.ToInt32(splashIV.Frame.Y)+ Convert.ToInt32(splashIV.Frame.Height) +50,
                                           Convert.ToInt32(View.Frame.Height) / 28,
			                               Convert.ToInt32(View.Frame.Height) / 28);
			orderIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width / 20),
			                              Convert.ToInt32(myCardIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height* 1.2),
			                              Convert.ToInt32(View.Frame.Height) / 28,
			                              Convert.ToInt32(View.Frame.Height) / 28);
			cloudIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width / 20),
			                              Convert.ToInt32(orderIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                              Convert.ToInt32(View.Frame.Height) / 28,
			                              Convert.ToInt32(View.Frame.Height) / 28);
			premiumIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width / 20),
			                                Convert.ToInt32(cloudIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                                Convert.ToInt32(View.Frame.Height) / 28,
			                                Convert.ToInt32(View.Frame.Height) / 28);
			aboutIV.Frame = new Rectangle(Convert.ToInt32((View.Frame.Width / 20) + 6),
			                              Convert.ToInt32(premiumIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                              Convert.ToInt32(View.Frame.Height) / 56,
			                              Convert.ToInt32(View.Frame.Height) / 28);
			enterIV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width / 20),
			                              Convert.ToInt32(View.Frame.Height) - Convert.ToInt32(aboutIV.Frame.Height*2),
			                              Convert.ToInt32(View.Frame.Height) / 28,
			                              Convert.ToInt32(View.Frame.Height) / 28);
			myCardBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X +enterIV.Frame.Width*1.5),
                                           Convert.ToInt32(splashIV.Frame.Y) + Convert.ToInt32(splashIV.Frame.Height) + 50,
			                               Convert.ToInt32(View.Frame.Width),
                                           Convert.ToInt32(View.Frame.Height) / 28);
			orderBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X + enterIV.Frame.Width * 1.5),
                                          Convert.ToInt32(myCardIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                              Convert.ToInt32(View.Frame.Width),
                                          Convert.ToInt32(View.Frame.Height) / 28);
			cloudBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X + enterIV.Frame.Width * 1.5),
                                          Convert.ToInt32(orderIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                              Convert.ToInt32(View.Frame.Width),
                                          Convert.ToInt32(View.Frame.Height) / 28);
			premiumBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X + enterIV.Frame.Width * 1.5),
                                            Convert.ToInt32(cloudIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                                Convert.ToInt32(View.Frame.Width),
                                            Convert.ToInt32(View.Frame.Height) / 28);
			aboutBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X + enterIV.Frame.Width * 1.5),
                                          Convert.ToInt32(premiumIV.Frame.Y) + Convert.ToInt32(myCardIV.Frame.Height) + Convert.ToInt32(myCardIV.Frame.Height * 1.2),
			                              Convert.ToInt32(View.Frame.Width),
                                          Convert.ToInt32(View.Frame.Height) / 28);
			enterBn.Frame = new Rectangle(Convert.ToInt32(enterIV.Frame.X + enterIV.Frame.Width * 1.5),
                                          Convert.ToInt32(View.Frame.Height) - Convert.ToInt32(aboutIV.Frame.Height * 2),
                                          Convert.ToInt32(View.Frame.Width),
                                          Convert.ToInt32(View.Frame.Height) / 28);
			myCardBn.SetTitle("Моя визитка", UIControlState.Normal);
			orderBn.SetTitle("Заказать наклейку c QR", UIControlState.Normal);
			cloudBn.SetTitle("Облачная синхронизация", UIControlState.Normal);
			premiumBn.SetTitle("Premium", UIControlState.Normal);
			aboutBn.SetTitle("О приложении", UIControlState.Normal);
			enterBn.SetTitle("Войти", UIControlState.Normal);


			var sb = UIStoryboard.FromName("Main", null);
			var vc = sb.InstantiateViewController("OnBoarding1ViewController");
			myCardIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			myCardBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			orderIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			orderBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			cloudIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			cloudBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			premiumIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			premiumBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			aboutIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			aboutBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			enterIV.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
			enterBn.TouchUpInside += (s, e) => { ViewController.navigationController.PushViewController(vc, true); };
		}
	}
}