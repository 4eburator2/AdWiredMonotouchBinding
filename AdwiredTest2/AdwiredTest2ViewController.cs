using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using AdwiredBinding;

namespace AdwiredTest
{
	public partial class AdwiredTest2ViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public AdwiredTest2ViewController ()
			: base (UserInterfaceIdiomIsPhone ? "AdwiredTest2ViewController_iPhone" : "AdwiredTest2ViewController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			AWView.DebugMode = true;

			UIView superDuperView = new UIView(this.View.Bounds);
			
			this.View.Add(superDuperView);

			AWView view = new AWView(new AdWiredDelegateImpl());
			view.Frame = View.Bounds;

			String placeId = "1";
			NSString[] strings = new NSString[]{new NSString("кафе"), new NSString("авто")};
			superDuperView.Add(view);

			bool bannerLoaded = view.LoadForPlaceId(placeId,strings);
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone) {
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else {
				return true;
			}
		}
	}
}

