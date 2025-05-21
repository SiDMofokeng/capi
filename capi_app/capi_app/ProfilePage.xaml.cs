using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace capi_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnProfileTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Tapped", "You tapped the profile row!", "OK");
            // You can navigate to another page here if needed
            // await Navigation.PushAsync(new DetailedProfilePage());
        }

        private async void OnUpdateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductProfile());
        }
    }
}