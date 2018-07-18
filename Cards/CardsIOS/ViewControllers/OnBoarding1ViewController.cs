using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace CardsIOS
{
	public partial class OnBoarding1ViewController : UIViewController
    {
        public OnBoarding1ViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//this.NavigationController.NavigationBarHidden = true;
			// Perform any additional setup after loading the view, typically from a nib.
			backgroundIV.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height));

			cardsLogo.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 3,
											Convert.ToInt32(View.Frame.Width) / 3,
											Convert.ToInt32(View.Frame.Width) / 3,
											Convert.ToInt32(View.Frame.Width) / 3);
			mainTextTV.Frame = new Rectangle(0, (Convert.ToInt32(cardsLogo.Frame.X) + Convert.ToInt32(View.Frame.Width) / 3) + 35, Convert.ToInt32(View.Frame.Width), 26);
			//var d = cardsLogo.Frame.X;
			mainTextTV.Text = "Создавайте визитки";
			mainTextTV.Font = mainTextTV.Font.WithSize(22f);
			infoLabel.Text = "Заполняйте личные" + "\r\n" + "и корпоративные данные," + "\r\n" + "добавляйте лого компании";

			infoLabel.Lines = 3;
			infoLabel.Frame = new Rectangle(0, Convert.ToInt32(mainTextTV.Frame.Y) + 29, Convert.ToInt32(View.Frame.Width), 100);
			nextBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 15,
										 (Convert.ToInt32(View.Frame.Height) / 10) * 8,
										 Convert.ToInt32(View.Frame.Width) - ((Convert.ToInt32(View.Frame.Width) / 15) * 2),
										 Convert.ToInt32(View.Frame.Height) / 12);
			nextBn.Font = mainTextTV.Font.WithSize(17f);
			nextBn.TouchUpInside += (s, e) =>
			  {
				  if (mainTextTV.Text == "Создавайте визитки")
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
				  }
				else if (mainTextTV.Text == "Заказывайте наклейки")
				{
					var sb = UIStoryboard.FromName("Main", null);
					var vc = sb.InstantiateViewController("RootMyCardViewController");
					this.NavigationController.PushViewController(vc, true);
				}
			  };
            
        }
    }
}