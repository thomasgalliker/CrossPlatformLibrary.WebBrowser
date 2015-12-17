using System;
using System.Threading.Tasks;

using CrossPlatformLibrary.Tracing;

using Guards;

namespace CrossPlatformLibrary.WebBrowser
{
    public abstract class WebBrowserBase : IWebBrowser
    {
        private readonly ITracer tracer;

        public WebBrowserBase(ITracer tracer)
        {
            Guard.ArgumentNotNull(() => tracer);

            this.tracer = tracer;
        }

        public void OpenUrl(string url)
        {
            Guard.ArgumentNotNullOrEmpty(() => url);

            try
            {
                this.OnOpenUrl(url);
            }
            catch (Exception ex)
            {
                this.tracer.Exception(ex, string.Format("Failed to OpenUrl with url={0}", url));
            }
        }

        protected abstract void OnOpenUrl(string url);
    }
}