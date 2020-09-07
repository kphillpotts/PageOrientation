using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PageOrientation.iOS;
using UIKit;
[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace PageOrientation.iOS
{
    public class OrientationService : IOrientationService
    {
        public void ForceLandscapeOrientation()
        {
            AppDelegate appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            appDelegate.allowRotation = PageOrientation.Landscape;
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientationMask.Landscape), new NSString("orientation"));
        }

        public void ForcePortraitOrientation()
        {
            AppDelegate appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            appDelegate.allowRotation = PageOrientation.Portrait;
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientationMask.Portrait), new NSString("orientation"));
        }
        public void AllowAnyOrientation()
        {
            AppDelegate appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            appDelegate.allowRotation = PageOrientation.Any;
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientationMask.All), new NSString("orientation"));
        }
    }
}