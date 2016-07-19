using System;
using Tracing;
using Windows.System;

namespace CrossPlatformLibrary.WebBrowser
{
    public class WebBrowser : WebBrowserBase
    {
        public WebBrowser(ITracer tracer)
            : base(tracer)
        {
        }

        protected override async void OnOpenUrl(string url)
        {
            await Launcher.LaunchUriAsync(new Uri(url));
        }
    }
}