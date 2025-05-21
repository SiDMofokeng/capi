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
	public partial class QuestionaireLanding : ContentPage
	{
		public QuestionaireLanding ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void StartInterview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterviewPage()); // Replace with your actual page
        }
    }
}