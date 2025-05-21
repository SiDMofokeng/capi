using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace capi_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Hide the navigation bar only on this page
            NavigationPage.SetHasNavigationBar(this, false);

            // Track when user leaves the username field
            usernameEntry.Unfocused += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("Username Entry unfocused.");
            };

            // Track when user leaves the password field
            passwordEntry.Unfocused += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("Password Entry unfocused.");
            };

        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(usernameEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isUsernameEmpty || isPasswordEmpty)
            {
                await DisplayAlert("Missing Information", "Please enter both username and password.", "OK");
                return;
            }

            Application.Current.MainPage = new NavigationPage(new HomePage());

        }
    }
}
