﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCommunity.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeView : Page
    {
        public HomeView()
        {
            this.InitializeComponent();
        }

        private async void DiscordButton_Click(object sender, RoutedEventArgs e)
        {
            await NavigationManager.OpenDiscordInvite("eBHZSKG");
        }

        private void Launch2020Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.Navigate(typeof(Views.LaunchView));
        }

        private async void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            await NavigationManager.OpenInBrowser("https://github.com/UWPCommunity/");
        }

        private async void Launch2019Button_Click(object sender, RoutedEventArgs e)
        {
            await NavigationManager.OpenInBrowser("https://medium.com/@Arlodottxt/launch-2019-7efd37cc0877");
        }
    }
}
