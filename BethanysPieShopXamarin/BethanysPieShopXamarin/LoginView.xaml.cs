﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView()
		{
			InitializeComponent();
		}

		private async void LoginButton_OnClicked(object sender, EventArgs e)
		{
			Navigation.InsertPageBefore(new MainView(), this);
			await Navigation.PopAsync();
		}
	}
}