using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageOrientation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IOrientationService>().AllowAnyOrientation();
        }

        private async void OrientationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrientationPage());
        }
        private async void LandscapeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LandscapePage());
        }
        private async void PortraitButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PortraitPage());
        }
    }
}
