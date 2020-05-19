using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Blanket_Launcher
{

    public sealed partial class StorePage : Page {

        string eshop = "https://www.nintendo.com/games/";
        string steam = "https://store.steampowered.com/";
        string xboxstore = "https://www.xbox.com/en-CA/games?xr=shellnav";
        string playstationstore = "https://store.playstation.com/en-ca/home/games";

        public StorePage() {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {

             switch (args.InvokedItemContainer.Tag)
             {
                case "back":
                    if (webView.CanGoBack) { webView.GoBack(); }
                    break;

                case "forward":
                    if (webView.CanGoForward) { webView.GoForward(); }
                    break;

                case "refresh":
                    webView.Refresh();
                    break;

                case "eshop":
                    webView.Navigate(new System.Uri(eshop));
                    break;

                case "steam":
                    webView.Navigate(new System.Uri(steam));
                    break;

                case "xboxstore":
                    webView.Navigate(new System.Uri(xboxstore));
                    break;

                case "playstationstore":
                    webView.Navigate(new System.Uri(playstationstore));
                    break;

                default:
                    webView.Navigate(new System.Uri("https://www.google.com/"));
                    break;
             }
        }

        private void checkIfSource(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            var sites = new List<string>() { "https://www.nintendo.com/games/",
                                         "https://store.steampowered.com/",
                                         "https://www.xbox.com/en-CA/games?xr=shellnav",
                                         "https://store.playstation.com/en-ca/home/games"};
            /*if (webView.Source.Equals(eshop) || webView.Source.Equals(steam) || webView.Source.Equals(xboxstore) || webView.Source.Equals(playstationstore))*/

            if (sites.Contains(webView.Source.ToString()))
            {
                 BackButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
             else
             {
                 BackButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
             }
        }
    }
}
