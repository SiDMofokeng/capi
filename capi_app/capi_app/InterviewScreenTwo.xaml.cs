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
	public partial class InterviewScreenTwo : ContentPage
	{
		public InterviewScreenTwo ()
		{
			InitializeComponent ();
            // Hide the navigation bar only on this page
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void AddMember_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterviewAddMember()); // Replace with your actual page
        }
    }
}