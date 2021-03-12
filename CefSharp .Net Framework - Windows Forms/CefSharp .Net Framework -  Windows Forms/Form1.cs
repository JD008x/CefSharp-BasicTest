using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace CefSharp.Net_Framework____Windows_Forms
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;

        public Form1()
        {
            InitializeComponent();

            InitializeChromium();
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            
            browser = new ChromiumWebBrowser("https://code.waters.com/");

            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
