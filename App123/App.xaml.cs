﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App123
{
    public partial class App : Application
    {
        public string DatabasePath;
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        
        public App(string databasePath)
        {
            InitializeComponent();
            
            DatabasePath = databasePath;

            MainPage = new NavigationPage(new MainPage());
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
