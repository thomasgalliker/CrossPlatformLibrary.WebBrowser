using System;

using Windows.System;

using CrossPlatformLibrary.Tracing;

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