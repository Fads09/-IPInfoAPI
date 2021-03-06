﻿using System;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace XamarinPart2
{
	public class Home : ContentPage
	{
		public Home ()
		{
            var label = new Label             {                 Text = "Location App",                 TextColor = Color.White,                 HorizontalOptions = LayoutOptions.Center,                 VerticalOptions = LayoutOptions.Center,                 FontAttributes = FontAttributes.Bold,                 FontSize = 20
               

               };
           
         

			Label jokeText = new Label {
				Text = "",
                TextColor  = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand,
				FontSize = 18,
                FontAttributes = FontAttributes.Bold
			};

            var button = new Button             {                 Text = "Find my location",                 HorizontalOptions = LayoutOptions.Center,                 WidthRequest = 180,                 BackgroundColor = Color.Purple,                 HeightRequest = 50,                 FontSize = 15,                 BorderRadius = 13,
                  TextColor = Color.White             } ; 
			button.Clicked+= async (sender, e) => {
				HttpClient client = new HttpClient();
                Uri uri = new Uri("https://ipinfo.io/json");
				string obstring = await client.GetStringAsync (uri);
				Joke joke = JsonConvert.DeserializeObject<Joke> (obstring);
                jokeText.Text = "You are located in " + " " + joke.city + " " + joke.region + " " + joke.country;
			};

			



            var stackLayout = new StackLayout             {                 BackgroundColor = Color.FromRgb(255, 179, 179),                 VerticalOptions = LayoutOptions.CenterAndExpand,                  Children = {                     label,  button, jokeText                 }              } ;              Content = new ScrollView             {                 Content = stackLayout,                 BackgroundColor = Color.FromRgb(255, 179, 179),                 Padding =new Thickness(10, 60)                                            } ; 
		}
	}
}


