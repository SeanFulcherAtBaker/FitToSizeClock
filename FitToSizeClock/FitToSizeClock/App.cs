using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FitToSizeClock
{
    public class App : Application
    {
        public App()
        {

            //Sets up FitToSizeClock Page
            MainPage = new FitToSizeClockPage();

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
    }
}
