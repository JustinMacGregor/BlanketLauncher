using Windows.UI.Xaml.Controls;

namespace Blanket_Launcher
{

    public sealed partial class StorePage : Page {
        public StorePage() {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            var param = args.InvokedItemContainer.Tag;
             switch (param)
             {
                // TO-DO: Dynamically change selected tab if GoBack() or GoForward() go to another store

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

                default:
                    webView.Navigate(new System.Uri("https://www.google.com/"));
                    break;
            }
        }
    }
}
