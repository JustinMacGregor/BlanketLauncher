using Blanket_Launcher.Views.StorePages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Blanket_Launcher {

    public sealed partial class StorePage : Page {
        public StorePage() {
            this.InitializeComponent();
        }


        //TO-DO: dynamically add/remove clients that exist within the system


        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            var param = args.InvokedItemContainer.Tag;
            ContentFrame.Navigate(typeof(LauncherStorePage), param);
        }
    }
}
