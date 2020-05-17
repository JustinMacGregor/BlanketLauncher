using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Blanket_Launcher
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // if settings is clicked
            if (args.IsSettingsInvoked) {
                ContentFrame.Navigate(typeof(SettingsPage));
            }

            // if settings is not clicked
            else {

                switch (args.InvokedItemContainer.Tag)
                {
                    case "store":
                        ContentFrame.Navigate(typeof(StorePage));
                        break;

                    case "games":
                        ContentFrame.Navigate(typeof(GamesPage));
                        break;

                    case "launchers":
                        ContentFrame.Navigate(typeof(LaunchersPage));
                        break;
                }
            }
        }
    }
}
