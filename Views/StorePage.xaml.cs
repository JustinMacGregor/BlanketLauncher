using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace Blanket_Launcher
{
    public sealed partial class StorePage : Page {

        public int _navigation = -1;

        public StorePage() {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
                switch (args.InvokedItemContainer.Tag)
                {
                    case "back":
                        if (webView.CanGoBack) {
                            _navigation = _navigation - 2;
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
                    _navigation = -2;
                    // TO-DO fix back button bug (selecting it multiple times will bring to other store page), change the cursor if the domain changes
                    webView.Navigate(new System.Uri(args.InvokedItemContainer.Tag.ToString()));
                        break;
                }
        }

        private void DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            BackButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            _navigation++;

            if (_navigation < -1) { _navigation = -1; }

            System.Diagnostics.Debug.WriteLine(_navigation.ToString());
            if (_navigation == -1) { BackButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed; } 
            else { BackButton.Visibility = Windows.UI.Xaml.Visibility.Visible; }
        }

        private void ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            BackButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void NewWindowRequested(WebView sender, WebViewNewWindowRequestedEventArgs args)
        {
            webView.Navigate(args.Uri);
            args.Handled = true;
        }

        // TO-DO: Save URL for each tab (session only)
    }
}
