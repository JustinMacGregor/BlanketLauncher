using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Blanket_Launcher
{

    public sealed partial class StorePage : Page {

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
                        // TO-DO: To completely squash the back button bug (clicking it more than once will go to another store page)
                        // Find a way to either 1. clear the history every time a new store is navigated to
                        //                      2. create a new instance of webview to reset the history (more expensive)
                        // then, if webView.CanGoBack() is false, hide the back button
                        webView.Navigate(new System.Uri("https://www.nintendo.com/games/"));
                        break;

                    case "steam":
                        webView.Navigate(new System.Uri("https://store.steampowered.com/"));
                        break;

                    case "xboxstore":
                        webView.Navigate(new System.Uri("https://www.xbox.com/en-CA/games?xr=shellnav"));
                        break;

                    case "playstationstore":
                        webView.Navigate(new System.Uri("https://store.playstation.com/en-ca/home/games"));
                        break;

                    case "battlenet":
                        webView.Navigate(new System.Uri("https://us.shop.battle.net/en-us"));
                        break;

                    case "origin":
                        webView.Navigate(new System.Uri("https://www.origin.com/can/en-us/store"));
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
                                             "https://store.playstation.com/en-ca/home/games",
                                             "https://us.shop.battle.net/en-us",
                                             "https://www.origin.com/can/en-us/store"};

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
