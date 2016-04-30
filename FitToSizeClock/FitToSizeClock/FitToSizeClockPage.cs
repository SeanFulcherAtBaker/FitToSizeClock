using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitToSizeClock
{
    public class FitToSizeClockPage : ContentPage
    {
        public FitToSizeClockPage()
        {
            Label clockLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Content = clockLabel;
            // Handles the SizeChanged event for this page. 
            SizeChanged += (object sender, EventArgs args) => 
            {
                // Scales the font size to match page width 
                // (book is based on 11 characters in the displayed string). 
                if (this.Width > 0) clockLabel.FontSize = this.Width / 6; };
            /* Start timer Changed it to 100 milliseconds to increase ods of 
             * matching up with systems clock as issue is described in book.*/ 
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                // Set the Text of the Label. 
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });

        }
    }
}
