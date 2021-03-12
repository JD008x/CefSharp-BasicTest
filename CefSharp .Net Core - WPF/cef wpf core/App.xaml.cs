using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace cef_wpf_core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*
        private void NavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AddressBox.Text))
            {
                Browser.Address = AddressBox.Text;
            }
          
        }
          */
        /*
        private void ChromiumWebBrowser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            
            Dispatcher.BeginInvoke((Action)(() =>
            {
                AddressBox.Text = e.Url;
                NavigateBtn.IsEnabled = !string.IsNullOrEmpty(AddressBox.Text);
            }
            ));
            
        }
        */
    }
}
