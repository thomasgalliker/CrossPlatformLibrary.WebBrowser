using Tracing;
#if __UNIFIED__
using UIKit;
using Foundation;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
#endif

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
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
    }
}