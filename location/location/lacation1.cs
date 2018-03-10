using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace location
{
    public class lacation1: ContentPage
    {
        public lacation1()
        {
            var label = new Label
            {
                Text = "Location App",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                FontSize = 40,
                Margin = new Thickness(0,10,0, 100)

            };

            var label2 = new Label
            {
                Text = "Enter your name to find your location",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                Margin = new Thickness(0, 100, 0, 0)
                                 
            };

            var entry = new Entry
            {
                Text = "Enter your name",
                TextColor = Color.Gray


                    
            };

            var button = new Button
            {
                Text = "Find my location",
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 180,
                BackgroundColor = Color.Blue,
                HeightRequest = 50,
                FontSize = 15,
                BorderRadius = 13,
                Margin = new Thickness(0, 50),
                TextColor = Color.White
            };

            var stackLayout = new StackLayout
            {
                BackgroundColor = Color.LightSkyBlue,
                VerticalOptions = LayoutOptions.StartAndExpand,

                Children = {
                    label, label2, entry, button
                }

            };

            Content = new ScrollView
            {
                Content = stackLayout,
                BackgroundColor = Color.LightSkyBlue,
                Padding =new Thickness(10, 60) 
            
               

            };


        }

    }
}

       