using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.Devices.AllJoyn;
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

                    default:
                    // TO-DO: To completely squash the back button bug (clicking it more than once will go to another store page)
                    // Find a way to move the cursor to another MenuItem when the domain name is different e.g. going from xbox to playstation
                    webView.Navigate(new System.Uri(args.InvokedItemContainer.Tag.ToString()));
                        break;
                }
        }
    }
}
