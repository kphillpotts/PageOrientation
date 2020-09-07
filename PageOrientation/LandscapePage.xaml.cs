using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageOrientation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandscapePage : ContentPage
    {
        public LandscapePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IOrientationService>().ForceLandscapeOrientation();
        }


    }
}