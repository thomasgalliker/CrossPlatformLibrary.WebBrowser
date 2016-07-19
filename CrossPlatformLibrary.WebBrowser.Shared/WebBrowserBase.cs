using System;

using Guards;

using Tracing;

namespace CrossPlatformLibrary.WebBrowser
{
    public abstract class WebBrowserBase : IWebBrowser
    {
        private readonly ITracer tracer;

        protected WebBrowserBase(ITracer tracer)
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