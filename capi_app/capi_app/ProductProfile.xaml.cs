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
	public partial class ProductProfile : ContentPage
	{
		public ProductProfile ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnUpdateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionaireLanding());
        }
    }
}