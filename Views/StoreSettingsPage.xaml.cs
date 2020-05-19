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

namespace Blanket_Launcher.Views
{
    public sealed partial class StoreSettingsPage : Page
    {
        public StoreSettingsPage()
        {
            this.InitializeComponent();
            // TO-DO: If store tabs are visible in StorePage.xaml, turn on the toggles.
        }

        // TO-DO: Fix bug where you cant go back to store tabs after accessing settings
        // (maybe when another tab is clicked, the page goes to StorePage.xaml)
    }
}
