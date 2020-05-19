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

namespace Blanket_Launcher.Views
{
    public sealed partial class StoreSettingsPage : Page
    {
        public StoreSettingsPage()
        {
            this.InitializeComponent();
            // TO-DO: If store tabs are visible in StorePage.xaml, turn on the toggles.
        }

        // TO-DO: When toggled, turn the visibility of the tab in StorePage to Visibility.Collapsed.
    }
}
