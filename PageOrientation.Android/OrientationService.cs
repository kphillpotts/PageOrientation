using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using PageOrientation;
using Android.Content.PM;
using PageOrientation.Droid;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace PageOrientation.Droid
{
    public class OrientationService : IOrientationService
    {
        public void ForceLandscapeOrientation()
        {
            Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Landscape;
        }

        public void ForcePortraitOrientation()
        {
            Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Portrait;
        }

        public void AllowAnyOrientation()
        {
            Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Unspecified;
        }
    }
}