using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebNavigationCEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(AddressBox.Text))
            {
                Browser.Address = AddressBox.Text;
            }
        }

        private void ChromiumWebBrowser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)(() =>
            {
                AddressBox.Text = e.Url;
                NavigateBtn.IsEnabled = !string.IsNullOrEmpty(AddressBox.Text);
            }               
            ));
        }
    }
}
