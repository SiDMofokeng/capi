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
	public partial class InterviewAddMember : ContentPage
	{
		public InterviewAddMember ()
		{
			InitializeComponent ();
            // Hide the navigation bar only on this page
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnAccordionHeaderTapped(object sender, EventArgs e)
        {
            AccordionBody.IsVisible = !AccordionBody.IsVisible;
        }
    }
}