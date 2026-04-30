using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace NexusBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            // Wait for the browser engine to be ready
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://www.google.com");
        }

        private void btnGo_Click(object? sender, EventArgs e) => Navigate();

        private void txtAddress_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                Navigate(); 
                e.SuppressKeyPress = true; 
            }
        }

        private void Navigate()
        {
            string url = txtAddress.Text;
            if (string.IsNullOrWhiteSpace(url)) return;

            // Simple logic: if it doesn't look like a URL, search Google
            if (!url.Contains(".") || url.Contains(" "))
            {
                url = "https://www.google.com/search?q=" + Uri.EscapeDataString(url);
            }
            else if (!url.StartsWith("http"))
            {
                url = "https://" + url;
            }
            
            webView.CoreWebView2?.Navigate(url);
        }

        private void btnBack_Click(object? sender, EventArgs e) => webView.GoBack();
        private void btnForward_Click(object? sender, EventArgs e) => webView.GoForward();

        private void webView_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            txtAddress.Text = webView.Source.ToString();
            this.Text = "Nexus Browser - " + (webView.CoreWebView2?.DocumentTitle ?? "Nexus");
        }
    }
}