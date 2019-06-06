using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new home();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
        private void PressMeButton_Pressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "You pressed me!";
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }
    }
}
