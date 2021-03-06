﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new LoginView();
            // MainPage = new RegisterView();
            // MainPage = new ContactView();
            // MainPage = new SettingsView();
            // MainPage = new WebPageView();
            // MainPage = new PieDetailView();

            // MainPage = new ContentPageView();
            // MainPage = new NavigationPage(new NavigationPageView());
            // MainPage = new TabbedPageView();
            // MainPage = new MasterDetailPageView();
            // MainPage = new CarouselPageView();

            // ListView
            // MainPage = new PieOverview();

            var alreadyRegistered = true;

            if (alreadyRegistered)
                MainPage = new MainView();
            else
                MainPage = new NavigationPage(new LoginView());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
