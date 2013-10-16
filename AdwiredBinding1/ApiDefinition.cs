//using System;
//using System.Drawing;
//using MonoTouch.ObjCRuntime;
//using MonoTouch.Foundation;
//using MonoTouch.UIKit;
//
//namespace AdwiredBinding1
//{
//	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
//	// to the project by right-clicking (or Control-clicking) the folder containing this source
//	// file and clicking "Add files..." and then simply select the native library (or libraries)
//	// that you want to bind.
//	//
//	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
//	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
//	// architectures that the native library supports and fills in that information for you,
//	// however, it cannot auto-detect any Frameworks or other system libraries that the
//	// native library may depend on, so you'll need to fill in that information yourself.
//	//
//	// Once you've done that, you're ready to move on to binding the API...
//	//
//	//
//	// Here is where you'd define your API definition for the native Objective-C library.
//	//
//	// For example, to bind the following Objective-C class:
//	//
//	//     @interface Widget : NSObject {
//	//     }
//	//
//	// The C# binding would look like this:
//	//
//	//     [BaseType (typeof (NSObject))]
//	//     interface Widget {
//	//     }
//	//
//	// To bind Objective-C properties, such as:
//	//
//	//     @property (nonatomic, readwrite, assign) CGPoint center;
//	//
//	// You would add a property definition in the C# interface like so:
//	//
//	//     [Export ("center")]
//	//     PointF Center { get; set; }
//	//
//	// To bind an Objective-C method, such as:
//	//
//	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
//	//
//	// You would add a method definition to the C# interface like so:
//	//
//	//     [Export ("doSomething:atIndex:")]
//	//     void DoSomething (NSObject object, int index);
//	//
//	// Objective-C "constructors" such as:
//	//
//	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
//	//
//	// Can be bound as:
//	//
//	//     [Export ("initWithElmo:")]
//	//     IntPtr Constructor (ElmoMuppet elmo);
//	//
//	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
//	//
//
//
//
//
//}
//


using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AdwiredBinding
{

	[Model]
	[BaseType (typeof (NSObject))]
	public interface AdWiredDelegate {

		[Export ("bannerDidStart:")]
		void BannerDidStart (AWView bannerView);

		[Export ("bannerDidStop:")]
		void BannerDidStop (AWView bannerView);

		[Export ("bannerDidFail:")]
		void BannerDidFail (AWView bannerView);
	}


	[BaseType (typeof (UIView))]
	public interface AWView {

		[Export ("placeId", ArgumentSemantic.Copy)]
		string PlaceId { get; set; }

		[Export ("keywords", ArgumentSemantic.Copy)]
		NSObject [] Keywords { get; set; }

		[Export ("bannerType")]
		AWBannerType BannerType { get; }

		[Export ("closeAnimation")]
		AWViewAnimation CloseAnimation { get; set; }

		[Export ("frameLocked")]
		bool FrameLocked { get; set; }

		[Export ("frameLock", ArgumentSemantic.Assign)]
		RectangleF FrameLock { get; set; }

		[Export ("fullscreenOrientationMask")]
		AWBannerOrientation FullscreenOrientationMask { get; set; }

		[Static, Export ("debugMode")]
		bool DebugMode { set; }

		[Static, Export ("isDebugMode")]
		bool IsDebugMode { get; }

		[Static, Export ("uniqueIdentifier")]
		string UniqueIdentifier { get; }

		[Static, Export ("uniqueIdentifier2")]
		string UniqueIdentifier2 { get; }

		[Static, Export ("initialize")]
		void Initialize ();

		[Export ("initWithDelegate:")]
		IntPtr Constructor (NSObject aDelegate);

		[Export ("initWithDelegate:rotationEnabled:")]
		IntPtr Constructor (NSObject aDelegate, bool rotationEnabled);

		[Export ("loadForPlaceId:")]
		bool LoadForPlaceId (string placeId);

		[Export ("loadForPlaceId:keywords:")]
		bool LoadForPlaceId (string placeId, NSObject [] keywords);

		[Static, Export ("checkForPlaceId:keywords:")]
		bool CheckForPlaceId (string placeId, NSObject [] keywords);

		[Export ("changeOrientation:")]
		void ChangeOrientation (UIInterfaceOrientation orientation);

		[Export ("removeWithAnimation:")]
		void RemoveWithAnimation (AWViewAnimation animation);

		[Export ("showInView:placeId:")]
		void ShowInView (UIView view, string placeId);

		[Export ("showInView:placeId:keywords:")]
		void ShowInView (UIView view, string placeId, NSObject [] keywords);

		[Export ("showBannerOnView:placeId:context:")]
		void ShowBannerOnView (UIView baseView, string placeId, string context);

		[Export ("hideBanner")]
		void HideBanner ();

		[Export ("modifyView")]
		void ModifyView ();
	}

}