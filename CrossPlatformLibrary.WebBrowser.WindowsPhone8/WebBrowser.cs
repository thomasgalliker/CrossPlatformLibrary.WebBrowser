using System;
using System.Windows;

using CrossPlatformLibrary.Tracing;

using Microsoft.Phone.Tasks;

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