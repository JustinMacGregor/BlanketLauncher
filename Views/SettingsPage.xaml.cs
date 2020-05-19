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

namespace Blanket_Launcher
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            StorePage sp = new StorePage();
            if (sp.ESHOP.Visibility == Windows.UI.Xaml.Visibility.Visible)
            {
                eshoptoggle.IsOn = true;
            }
            // For each tab in storepage.xaml
            // If the visibility is visible
            // isOn = true

            // TO-DO: If store tabs are visible in StorePage.xaml, turn on the toggles.
        }
    }
}
