using Hc2Api;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HCApp
{
    public sealed partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            this.InitializeComponent();
        }

        private async void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            DisableControl();
            Hc2Connection hc2cn = new Hc2Connection();
            await hc2cn.Connect(tbHc2Url.Text, tbUsername.Text, pbPassword.Password);
            //this.Visibility = Visibility.Collapsed;
        }

        private void DisableControl()
        {
            tbHc2Url.IsEnabled = false;
            tbUsername.IsEnabled = false;
            pbPassword.IsEnabled = false;
            btnConnect.IsEnabled = false;
        }
    }
}
