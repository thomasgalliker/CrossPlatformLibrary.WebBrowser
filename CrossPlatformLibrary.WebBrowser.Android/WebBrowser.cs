using System;
using System.Threading.Tasks;

using Android.Content;

using CrossPlatformLibrary.Tracing;

using Guards;

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
            var intent = new Intent(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse(url));

            intent.SetFlags(ActivityFlags.ClearTop);
            intent.SetFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}