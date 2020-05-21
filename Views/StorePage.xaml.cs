using Windows.UI.Xaml.Controls;

namespace Blanket_Launcher
{
    public sealed partial class StorePage : Page {

        string _currentHost = "";

        public StorePage() {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
                switch (args.InvokedItemContainer.Tag)
                {
                    case "back":
                        if (webView.CanGoBack) {
                            webView.GoBack();
                        }
                        break;

                    case "forward":
                        if (webView.CanGoForward) {
                            webView.GoForward(); 
                        }
                        break;

                    case "refresh":
                        webView.Refresh();
                        break;

                    default:
                    //to fix back button bug (selecting it multiple times will bring to other store page), change the cursor if the domain changes
                        webView.Navigate(new System.Uri(args.InvokedItemContainer.Tag.ToString()));
                        break;
                }
        }
    }
}
