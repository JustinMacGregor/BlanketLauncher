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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Blanket_Launcher.Views.StorePages
{
    public sealed partial class LauncherStorePage : Page
    {
        public LauncherStorePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);

            switch (e.Parameter)
            {
                case "eshop":
                    webView.Source = new System.Uri("https://www.nintendo.com/games/");
                    break;

                case "steam":
                    webView.Source = new System.Uri("https://store.steampowered.com/");
                    break;

                case "xboxstore":
                    webView.Source = new System.Uri("https://www.xbox.com/en-CA/games?xr=shellnav");
                    break;

                case "playstationstore":
                    webView.Source = new System.Uri("https://store.playstation.com/en-ca/home/games");
                    break;

                default:
                    webView.Source = new System.Uri("https://www.google.com/");
                    break;
            }
        }
    }
}
