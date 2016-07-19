using System;
using System.Windows;

using Microsoft.Phone.Tasks;

using Tracing;

namespace CrossPlatformLibrary.WebBrowser
{
    public class WebBrowser : WebBrowserBase
    {
        public WebBrowser(ITracer tracer)
            : base(tracer)
        {
        }

        protected override void OnOpenUrl(string url)
        {
            var webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri(url, UriKind.Absolute);

            Deployment.Current.Dispatcher.BeginInvoke(webBrowserTask.Show);
        }
    }
}