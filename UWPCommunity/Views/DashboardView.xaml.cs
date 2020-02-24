﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPCommLib.Api.UWPComm.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCommunity.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DashboardView : Page
    {
        public ObservableCollection<Project> Projects { get; set; } = new ObservableCollection<Project>();
        public DashboardView()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Common.IsInternetAvailable())
            {
                var projs = await Common.UwpCommApi.GetUserProjects(Common.DiscordUser.DiscordId);
                foreach (var project in projs)
                {
                    Projects.Add(project);
                }

                UserProfilePicture.ProfilePicture =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage(Common.DiscordUser.AvatarUri);
                UserProfileUsername.Text = Common.DiscordUser.Username;
            }
            else
            {
                Console.WriteLine("Internet not available");
            }
            
            base.OnNavigatedTo(e);
        }
    }
}
