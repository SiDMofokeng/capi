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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnTappedMyWork(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkDashboard());
        }

        private async void OnTappedDashboard(object sender, EventArgs e)
        {
            await DisplayAlert("Tapped", "You tapped Dashboard", "OK");
            // await Navigation.PushAsync(new DashboardPage());
        }

        private async void OnTappedSignOff(object sender, EventArgs e)
        {
            await DisplayAlert("Tapped", "You tapped My Work Sign-Off", "OK");
            // await Navigation.PushAsync(new SignOffPage());
        }
    }
}
